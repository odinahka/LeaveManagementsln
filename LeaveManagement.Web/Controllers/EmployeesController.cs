﻿using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public EmployeesController(UserManager<Employee> userManager, 
                                                IMapper mapper,
                                                ILeaveAllocationRepository leaveAllocationRepository,
                                                ILeaveTypeRepository leaveTypeRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.leaveTypeRepository = leaveTypeRepository;
        }
        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var model = mapper.Map<List<EmployeeListVM>>(employees);
            return View(model);
        }

        // GET: EmployeesController/viewAllocations/employeeId
        public async Task<ActionResult> viewAllocations(string id)
        {
            var model = await leaveAllocationRepository.GetEmployeeAllocation(id);
            return View(model);
        }

        // GET: EmployeesController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var model = await leaveAllocationRepository.GetEmployeeAllocation(id.Value);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
    }

        // POST: EmployeesController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(LeaveAllocationEditVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (!await leaveAllocationRepository.UpdateEmployeeAllocation(model))
                        return NotFound();

                    return RedirectToAction(nameof(viewAllocations), new { id = model.EmployeeId });
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong, try again later");
            }
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = mapper.Map<LeaveTypeVM>(await leaveTypeRepository.GetAsync(model.LeaveTypeId));
            return View(model);
        }
    }
}