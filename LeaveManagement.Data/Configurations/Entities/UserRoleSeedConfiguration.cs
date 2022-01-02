using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities    
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string> { 
                RoleId = "c118fd0f-ad21-4ae9-aa1b-2217a9e86477",
                UserId = "49f62bbb-1296-44a6-9879-1bd18a65f6c6"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "b062d856-433d-4b10-92d2-721e3e45343d",
                    UserId = "9d36312a-6fe4-4a5b-ae46-0b3414039109"
                }
                );
        }
    }
}