using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter.Core
{
    class Checks
    {
        static public bool IsBinary(string num)
        {
            foreach (char letter in num)
            {
                switch (letter)
                {
                    case '0':
                    case '1':
                        //Avoid Default
                        break;
                    default:
                        return false;
                }
            }

            return true;
        }

        public static bool IsHexadecimal(string hex)
        {
            foreach (char c in hex)
            {
                if ( !( (c >= '0' && c <= '9') ||
                        (c >= 'a' && c <= 'f') ||
                        (c >= 'A' && c <= 'F') )) //Not a Hex character (Chars can be compared like numbers)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsHexColor(string hexVal)
        {
            if (IsHexadecimal(hexVal))
            {
                int len = hexVal.Length;
                return (len == 3 || len == 6);
            }
            else
            {
                return false;
            }
        }
    }
}
