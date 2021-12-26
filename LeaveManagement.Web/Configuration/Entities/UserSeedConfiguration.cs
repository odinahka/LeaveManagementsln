using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hash = new PasswordHasher<Employee>();

            builder.HasData(
                new Employee
                {
                    Id = "49f62bbb-1296-44a6-9879-1bd18a65f6c6",
                    Email = "nobelshaka@gmail.com",
                    NormalizedEmail = "NOBELSHAKA@GMAIL.COM",
                    UserName = "nobelshaka@gmail.com",
                    NormalizedUserName = "NOBELSHAKA@GMAIL.COM",
                    Firstname = "Odinaka",
                    Lastname = "Afocha",
                    PasswordHash = hash.HashPassword(null, "Password@1"),
                    EmailConfirmed = true

                },
                new Employee
                {
                    Id = "9d36312a-6fe4-4a5b-ae46-0b3414039109",
                    Email = "user@user.com",
                    NormalizedEmail = "USER@USER.COM",
                    UserName = "user@user.com",
                    NormalizedUserName = "USER@USER.COM",
                    Firstname = "Odinaka",
                    Lastname = "Afocha",
                    PasswordHash = hash.HashPassword(null, "Password@1"),
                    EmailConfirmed = true
                }
                );
        }
    }
}