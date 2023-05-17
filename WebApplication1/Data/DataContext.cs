using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography;
using WebApplication1.Entities;

namespace WebApplication1.Data
{
    public class DataContext : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<AttendenceConfigs> AttendenceConfiguration { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedUserRoles(builder, out Guid adminRoleId);
            SeedAdmin(builder, adminRoleId);
        }

        private void SeedUserRoles(ModelBuilder builder, out Guid adminRoleId)
        {
            var adminRole = new IdentityRole<Guid>()
            {
                Id = Guid.NewGuid(),
                Name = "ADMIN",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = DateTime.UtcNow.Ticks.ToString()
            };

            adminRoleId = adminRole.Id;

            var employeeRole = new IdentityRole<Guid>()
            {
                Id = Guid.NewGuid(),
                Name = "EMPLOYEE",
                NormalizedName = "EMPLOYEE",
                ConcurrencyStamp = DateTime.UtcNow.Ticks.ToString()
            };

            builder.Entity<IdentityRole<Guid>>()
                .HasData(adminRole, employeeRole);
        }

        private void SeedAdmin(ModelBuilder builder, Guid adminRoleId) {

            var adminUser = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                SecurityStamp = DateTime.UtcNow.Ticks.ToString()
            };

            PasswordHasher<ApplicationUser> hasher = new();
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "admin123");

            IdentityUserRole<Guid> adminRole = new()
            {
                RoleId = adminRoleId,
                UserId = adminUser.Id
            };

            builder.Entity<ApplicationUser>()
                 .HasData(adminUser);

            builder.Entity<IdentityUserRole<Guid>>()
                .HasData(adminRole);
        }
    }
}
