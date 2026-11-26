using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSys
{
    public class Nurse : HospitalStaff
    {
        public Nurse(int id, string name) : base (id, name)
        {
        }

        public override string PerformDuty()
        {
            return "NURSE performs duty";
        }
    }
}
