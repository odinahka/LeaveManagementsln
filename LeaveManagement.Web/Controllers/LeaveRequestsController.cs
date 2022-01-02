#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Authorization;

namespace LeaveManagement.Web.Controllers
{
    [Authorize]
    public class LeaveRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILeaveRequestRepository leaveRequestRepository;

        public LeaveRequestsController(ApplicationDbContext context, ILeaveRequestRepository leaveRequestRepository)
        {
            _context = context;
            this.leaveRequestRepository = leaveRequestRepository;
        }

        [Authorize(Roles = Roles.Administrator)]
        // GET: LeaveRequests
        public async Task<IActionResult> Index()
        {
            var model = await leaveRequestRepository.GetAdminLeaveRequests();
            return View(model);
        }

        // GET: LeaveRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var leaveRequest = await leaveRequestRepository.GetLeaveRequest(id.Value);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            return View(leaveRequest);
        }
        //POST: LeaveRequests/ApproveRequest
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ApproveRequest(int id, bool? approved)
        {
            try
            {
                await leaveRequestRepository.ChangeApprovalStatus(id, approved.Value);
                
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", errorMessage: "Something went wrong, try again later");
                return View();
            }
           return RedirectToAction(nameof(Index));


        }
        // GET: LeaveRequests/Create
        public IActionResult Create()
        {
            var model = new LeaveRequestCreateVM { 
            LeaveType = new SelectList(_context.LeaveTypes, "Id", "Name", "")
            };
            return View(model);
        }

        // POST: LeaveRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( LeaveRequestCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   if( await leaveRequestRepository.CreateLeaveRequest(model))
                    return RedirectToAction(nameof(MyLeave));
                    else
                    {
                        ModelState.AddModelError("", errorMessage: "Please Select a valid leave request");
                    }
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error has occured, please try again later");  
            }
            model.LeaveType = new SelectList(_context.LeaveTypes, "Id", "Name", model.LeaveTypeId);
           
            return View(model);
        }

        public async Task<ActionResult> MyLeave()
        {
            var model = await leaveRequestRepository.GetMyLeaveDetails();
            return View(model);
        }

        // GET: LeaveRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }
            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveRequest.LeaveTypeId);
            return View(leaveRequest);
        }

      
        // GET: LeaveRequests/Delete/5
        public async Task<IActionResult> CancelLeaveRequest(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await leaveRequestRepository.CancelLeaveRequest(id.Value);

            return RedirectToAction(nameof(MyLeave));
        }

        // POST: LeaveRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            _context.LeaveRequests.Remove(leaveRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
