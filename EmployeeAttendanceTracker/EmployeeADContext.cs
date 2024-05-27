using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EmployeeAttendanceTracker
{
    internal class EmployeeADContext : DbContext
    {
        public EmployeeADContext()
        {
        }

        public EmployeeADContext(DbContextOptions<EmployeeADContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
        public DbSet<Absence> Absences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cs = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true,
               reloadOnChange: true).Build().GetConnectionString("EmployeeAD")!;

            optionsBuilder.UseSqlServer(cs);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(e =>
            {
                e.HasData(SeedData.Employees);
            });
            modelBuilder.Entity<Dependent>(d =>
            {
                d.HasData(SeedData.Dependents);
            });
            modelBuilder.Entity<Absence>(a =>
            {
                a.HasData(SeedData.Absences);
            });
        }
        }
}
