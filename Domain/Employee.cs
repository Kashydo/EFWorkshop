﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWorkshop.Domain
{
    public class Employee
    {

        public int Id { get; set; }
        [Required] 
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Salary { get; set; }

        public override string ToString()
        {
            return $"{FirstName}, {LastName} zarabia {Salary}";
        }

        public bool NameStartsWith(string letter) { return FirstName.StartsWith(letter); }
    }


}
