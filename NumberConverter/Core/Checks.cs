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
    }
}
