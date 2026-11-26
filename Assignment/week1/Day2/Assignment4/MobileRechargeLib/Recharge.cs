using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRechargeLib
{
    #region
    /// <summary>
    /// class with methods to calculate gst amount and total final amount
    /// </summary>
    #endregion

    public class Recharge
    {
        long mobileNumber;
        public long MobileNumber
        {
            get
            {
                return mobileNumber;
            }
            set
            {
                if(value.ToString().Length == 10)
                {
                    mobileNumber = value;
                }
                else
                {
                    mobileNumber = -1;
                }
            }
        }

        public double PlanAmount { get; set; }

        double gst = 0.18;

        // method to calculate GST (amount * 0.18)
        public double CalculateGST()
        {
            return PlanAmount * gst;
        }

        // method to find final payable amount (amount + gst amount)
        public double CalculateFinalAmount()
        {
            return PlanAmount + CalculateGST();
        }
    }
}
