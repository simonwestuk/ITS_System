using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ITS_System.Models;
using Microsoft.AspNetCore.Identity;

namespace ITS_System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
           
            SeedRoles(builder);
            SeedAdmin(builder);
            SeedUserRoles(builder);

        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "78bf8cbe-1f70-4d6d-890b-247bc57e6150",
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper(),
                    ConcurrencyStamp = "7b483dfe-e56c-4d5b-97cd-b32652794d29"

                }
            );

        }

        private void SeedAdmin(ModelBuilder builder)
        {
            PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
            IdentityUser user = new IdentityUser();
            user.Id = "27b9af34-a133-43e2-8dd2-aef04ddb2b8c";
            user.UserName = "admin@admin.com";
            user.NormalizedUserName = "admin@admin.com".ToUpper();
            user.NormalizedEmail = "admin@admin.com".ToUpper();
            user.Email = "admin@admin.com";
            user.LockoutEnabled = false;
            user.ConcurrencyStamp = "7b483dfe-e56c-4d5b-97cd-b32652794d29";
            user.PasswordHash = hasher.HashPassword(user, "Admin123!");
            builder.Entity<IdentityUser>().HasData(user);

        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(

                new IdentityUserRole<string>()
                {
                    RoleId = "78bf8cbe-1f70-4d6d-890b-247bc57e6150",
                    UserId = "27b9af34-a133-43e2-8dd2-aef04ddb2b8c"
                });


        }



    }
}