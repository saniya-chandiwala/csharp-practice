using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailRegLib
{
    public class EmailData
    {
        static HashSet<string> emails = new HashSet<string>() {
            "saniya@gmail.com",
            "ayesha@gmail.com",
            "priya@gmail.com",
            "niyati@gmail.com",
            "vanshika@gmail.com",
            "muskan@gmail.com",
            "peter@gmail.com",
            "john@gmail.com",
            "alice@gmail.com",
            "bob@gmail.com"
        };

        public HashSet<string> GetHashSetData()
        {
            return emails;
        }
    }
}
