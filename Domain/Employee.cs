using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWorkshop.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Salary { get; set; }

        public override string ToString()
        {
            return $"{FirstName}, {LastName} zarabia {Salary}";
        }
    }

    
}
