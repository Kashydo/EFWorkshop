using EFWorkshop.Data;
using EFWorkshop.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFWorkshop.IUTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companyContext = new CompanyContext();
            var employees = companyContext.Employees;
            //var e = employees.FirstOrDefault(x => x.Id == 2);
            //var e2 = employees.FirstOrDefault(x => x.Id == 2);
            //var e3 = employees.FirstOrDefault(x => x.Id == 2);
            //var b = employees.Find(4);
            //b.FirstName = "Marek";
            //var emp = new Employee { FirstName = "Joanna", LastName = "Mak", Salary = "3" };
            //companyContext.Employees.Add(emp);

            var c = employees.Find(4);
            companyContext.Employees.Remove(c);
            companyContext.SaveChanges();
        }
    }
}