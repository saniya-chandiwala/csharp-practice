using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalMngmtLib
{
    public class EmpDictionary
    {
        static Dictionary<int, double> emps = new Dictionary<int, double>();

        public Dictionary<int, double> GetEmpDictionary()
        {
            return emps;
        }
    }
}
