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
            var e4 = employees.Find(2);
            var e5 = employees.Find(2);
            var e6 = employees.Find(2);

        }
    }
}