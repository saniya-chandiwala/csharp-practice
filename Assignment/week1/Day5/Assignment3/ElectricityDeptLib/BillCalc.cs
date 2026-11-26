using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityDeptLib
{
    public class BillCalc
    {
        public int ConsumerNumber { get; set; }
        public double UnitsConsumed { get; set; }
        const double ratePerUnit = 0.8;

        public double CalculateBill()
        {
            return UnitsConsumed * ratePerUnit;
        }


    }
}
