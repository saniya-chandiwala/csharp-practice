using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLib
{
    public class Recharge
    {
        int mobileNumber;  
        double gst = 0.18;

        // method to calculate GST
        public double CalculateGST(double planAmount)
        {
            return planAmount * this.gst;
        }

        // method to find final payable amount
        public double CalculateFinalAmount(double planAmount)
        {
            return planAmount + CalculateGST(planAmount);
        }
    }
}
