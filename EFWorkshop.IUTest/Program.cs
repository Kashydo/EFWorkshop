using EFWorkshop.Data;
using EFWorkshop.Domain;

namespace EFWorkshop.IUTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companyContext = new CompanyContext();
            var employees = companyContext.Employees;

            foreach (var employee in employees)
            { 
                Console.WriteLine(employee);
            }
        }
    }
}