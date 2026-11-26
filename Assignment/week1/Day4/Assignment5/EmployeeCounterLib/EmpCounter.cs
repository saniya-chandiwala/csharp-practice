using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCounterLib
{
    public class EmpCounter
    {
        static int count = 0;

        public int GenerateCount()
        {
            return count++;
        }
    }
}
