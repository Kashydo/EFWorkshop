using EFWorkshop.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWorkshop.Data
{
    public class CompanyContext : DbContext
    {
        private const string ConnectionString = "Data Source=DESKTOP-FLUTGQS\\SQLEXPRESS;Database=CompanyDB;Integrated Security=true;TrustServerCertificate=true";
        
        public DbSet<Employee> Employees { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);





            base.OnConfiguring(optionsBuilder);
        }
    }
}
