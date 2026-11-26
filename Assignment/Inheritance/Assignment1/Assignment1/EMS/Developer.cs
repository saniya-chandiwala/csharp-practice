using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    public class Developer : Employee
    {
        public override double CalculateBonus()
        {
            return Salary * 0.10;
        }
    }
}
