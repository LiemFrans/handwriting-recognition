using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handwriting_recognition
{
    class Util
    {
        public static int charToIntegerPosition(char c)
        {
            return char.ToUpper(c) - 64;
        }

        public static int[] digitArr(int n)
        {
            string s = Convert.ToString(n, 2);
            int[] bits = s.PadLeft(Constants.LENGTH_ARRAYS_BITS, '0') // Add 0's from left
             .Select(c => int.Parse(c.ToString())) // convert each char to int
             .ToArray(); // Convert IEnumerable from select to Array
            return bits;
        }
    }
}
