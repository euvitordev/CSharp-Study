using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.Algoritmos
{
    public class ValidatePin
    {
        public static bool Solution(string pin)
        {
            bool isValid = false;
            if (pin.Length == 4 || pin.Length == 6)
            {
                for (int i = 0; i < pin.Length; i++)
                {
                    if (char.IsDigit(pin[i])) isValid = true;
                    else
                    {
                        return false;
                        break;
                    }

                }
            }
            return isValid;
        }
    }
}
