using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EFWorkshop.Domain
{
    public class PassportInfo
    {
        public int Id { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return Number;
        }
    }

}
