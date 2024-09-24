using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { 
                Id = "9c247f5b-55dc-478b-ac40-080ab6ed9eac",
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
                },
                new IdentityRole {
                    Id = "255b9104-2176-4a41-a875-d815679d28bb",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                },
                new IdentityRole {
                    Id = "49ccc939-98d4-4de6-bd09-33612039d9fe",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                });


            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "16064531-fb07-4ec7-affb-8affa7edeec0",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName = "ADMIN@LOCALHOST",
                UserName = "admin@localhost",
                PasswordHash = hasher.HashPassword(null, "Dimnokot123!"),
                EmailConfirmed = true,
                FirstName = "Default",
                LastName = "Admin",
                DateOfBirth = new DateOnly(1950,12,01)
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "49ccc939-98d4-4de6-bd09-33612039d9fe",
                UserId = "16064531-fb07-4ec7-affb-8affa7edeec0"
            });
        }


        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
