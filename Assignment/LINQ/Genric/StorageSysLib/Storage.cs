using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSysLib
{
    public class Storage<T>
    {
        T value;

        public void SetValue(T value)
        {
            this.value = value;
        }

        public T GetValue()
        {
            return value;
        }
    }
}
