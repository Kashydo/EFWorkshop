using EFWorkshop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWorkshop.Data
{
    public class CompanyContext : DbContext
    {
        private const string ConnectionString = "Data Source=DESKTOP-EF0N0IS\\SQLEXPRESS;Database=Company;Integrated Security=true;TrustServerCertificate=true";
        
        public DbSet<Employee> Employees { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging();

            }




            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(x => x.FirstName).IsRequired().HasColumnType("nvarchar(50)");
            base.OnModelCreating(modelBuilder);
        }
    }
}
