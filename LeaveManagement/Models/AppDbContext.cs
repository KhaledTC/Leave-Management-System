using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Seed(modelBuilder);
        }

        void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = "admin",
                    UserName = "admin",
                    NormalizedUserName = "Admin",
                    Department = "admin",
                    FirstName = "",
                    LastName = "",
                    Role = "",
                    PasswordHash = "AQAAAAEAACcQAAAAEDnzLtiKg8b97znMazhUEC7GvmgVHSew3FvekhFUYt2ZHmoF9qjhr6i6Z41cTp3vJQ=="
                });

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "admin",
                    Name = "admin",
                    NormalizedName = "Admin"
                }, new IdentityRole()
                {
                    Id = "Employee",
                    Name = "Employee",
                    NormalizedName = "Employee"
                }, new IdentityRole()
                {
                    Id = "Manager",
                    Name = "Manager",
                    NormalizedName = "Manager"
                });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = "admin",
                    UserId = "admin"
                });
        }
    }
}
