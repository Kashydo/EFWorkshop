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
            // var e = employees.FirstOrDefault(x => x.FirstName.StartsWith("Z"));
            // var e2 = employees.Find(2);
            // var e = employees.First();
            // var e = employees.FirstOrDefault(x => x.Id == 2);
            // var e2 = employees.FirstOrDefault(x => x.Id == 2);
            // var e3 = employees.FirstOrDefault(x => x.Id == 2);
            // var e4 = employees.Find(2);
            // var e5 = employees.Find(2);
            // var e6 = employees.Find(2);
            //var b = employees.Find(4);
            //b.FirstName = "Marian";
            //var emp = new Employee { FirstName = "Dżon", LastName = "Lennon", Salary = "4000" };
            //companyContext.Employees.Add(emp);

            var c = employees.First(x => x.Id == 5);
            companyContext.Employees.Remove(c);

            companyContext.SaveChanges();

            //foreach (var employee in employees)
            //{ 
            //    Console.WriteLine(employee);
            //}
        }
    }
}