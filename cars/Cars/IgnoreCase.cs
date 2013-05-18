using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public static class IgnoreCase
    {
        public static bool EqualsIgnoreCase(this string entry, string compareTo)
        {
            return entry.ToLower() == compareTo.ToLower();
        }
    }
}
