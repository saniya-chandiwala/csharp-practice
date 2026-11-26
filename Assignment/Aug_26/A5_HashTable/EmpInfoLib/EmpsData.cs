using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpInfoLib
{
    public class EmpsData
    {
        static Hashtable emps = new Hashtable()
        {
            { 101,"Saniya" },
            { 102, "Ayesha" },
            { 103, "Priya" },
            { "abc", "Niyati" },
            { 105, "Samira" }
        };

        public Hashtable GetHashTableData()
        {
            return emps;
        }
    }
}
