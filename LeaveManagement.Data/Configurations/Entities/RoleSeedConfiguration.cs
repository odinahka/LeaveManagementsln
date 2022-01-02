
using LeaveManagement.Common.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "c118fd0f-ad21-4ae9-aa1b-2217a9e86477",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()

                },
                new IdentityRole
                {
                    Id = "b062d856-433d-4b10-92d2-721e3e45343d",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }

            ) ;
        }
    }
}