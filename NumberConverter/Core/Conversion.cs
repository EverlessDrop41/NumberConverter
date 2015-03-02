using System;
using System.Collections.Generic;

namespace NumberConverter.Core
{
    /// <summary>
    /// The core class for the conversion techniques
    /// </summary>
    class Conversion
    {
        public static Dictionary<long, char> numToLet
            = new Dictionary<long, char> 
            { 
                #region assignment
                {0, '0'},
                {1, '1'},
                {2, '2'},
                {3, '3'},
                {4, '4'},
                {5, '5'},
                {6, '6'},
                {7, '7'},
                {8, '8'},
                {9, '9'},
                {10,'A'},
                {11,'B'},
                {12,'C'},
                {13,'D'},
                {14,'E'},
                {15,'F'}
                #endregion
            };

        public static Dictionary<char, int> letToNum
            = new Dictionary<char, int> 
            { 
                #region assignment
                {'0', 0},
                {'1', 1},
                {'2', 2},
                {'3', 3},
                {'4', 4},
                {'5', 5},
                {'6', 6},
                {'7', 7},
                {'8', 8},
                {'9', 9},
                {'A', 10},
                {'B', 11},
                {'C', 12},
                {'D', 13},
                {'E', 14},
                {'F', 15}
                #endregion
            };

        public static List<char> allowedChars
            = new List<char> 
            { 
                #region assignment
                {'0'},
                {'1'},
                {'2'},
                {'3'},
                {'4'},
                {'5'},
                {'6'},
                {'7'},
                {'8'},
                {'9'},
                {'A'},
                {'B'},
                {'C'},
                {'D'},
                {'E'},
                {'F'}
                #endregion
            };

        /// <summary>
        /// The highest base that is currently supported
        /// </summary>
        public static readonly int maxBase = 16;

        /// <summary>
        /// Takes a number string (e.g. 4A1CF) and returns that in denary form
        /// </summary>
        /// <param name="num">A number in string form that you wish to translate to binary</param>
        /// <param name="numBase">The base of the number you are passing in</param>
        static public long ToDenary(string num, int Base)
        {
            num = reverseString(num);
            long den = 0;
            for (int i = 0; i < num.Length; i++)
            {
                long x = letToNum[num[i]];
                den += (x * (long)Math.Pow(Base, i));
            }
            return den;
        }

        /// <summary>
        /// Takes a denary number and then converts it to the given base
        /// </summary>
        /// <param name="num">Original Number</param>
        /// <param name="Base">Base to convert to</param>
        /// <returns></returns>
        static public string fromDenary(long num, int Base)
        {
            decimal opNum = num;
            string returnNum = "";

            if (Base > maxBase)
            {
                throw new Exception("Base unsupported", new ArgumentException());
            }

            if (num == 0)
            {
                return "0";
            }

            while (opNum >= Base)
            {
                long tempNum = (long)opNum % Base;
                returnNum += numToLet[tempNum];
                opNum = Math.Floor(opNum / Base);
            }
            int TNum = (int)opNum % Base;
            returnNum += numToLet[TNum];

            return returnNum;
        }
        /*
        static public string fromDenary(int num, int Base)
        {
            long tmpNum = long.Parse(num.ToString());
            return fromDenary(tmpNum, Base);
        } */

        /// <summary>
        /// Returns a string in a reversed order (HEY -> YEH)
        /// </summary>
        /// <param name="str">The string to reverse</param>
        /// <returns></returns>
        static public string reverseString(string str)
        {
            char[] revArr = str.ToCharArray();
            Array.Reverse(revArr);

            return new string(revArr);
        }

        /// <summary>
        /// Takes a binary string and converts it to human readable text
        /// </summary>
        /// <param name="binary">Binary in string form</param>
        static public string binaryToSentence(string binary)
        {
            string retStr = String.Empty;
            string[] binaryArray = binary.Split();

            for (int i = 0; i < binaryArray.Length; i++)
            {
                if (binaryArray[i].Length == 8 && Checks.IsBinary(binaryArray[i]))
                {
                    retStr += (char)ToDenary(binaryArray[i],2);
                }
                else if (binaryArray[i] == " ")
                {
                    retStr += ' ';
                }
                else
                {
                    retStr = "Use 8-bit binary to get a sentence";
                    return retStr;
                }
            }
            

            return retStr;
        }
    }
}