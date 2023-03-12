using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal static class Extention
    {
        public static bool CheckPin(this string pin)
        {
            if (pin.Length == 7 && pin == pin.ToUpper())
            {
                return true;
            }
            throw new Exception("Try To Write True Pin");
        }
    }
}
