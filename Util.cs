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
            return Array.IndexOf(Constants.ALPHA,c);
        }

        public static char integerToChar(int i)
        {
            return Constants.ALPHA[i];
        }

        public static int[] intToArrays(int n)
        {
            int[] arrays = Enumerable.Repeat(0, Constants.LENGTH_ARRAYS_BITS).ToArray();
            arrays[n] = 1;
            return arrays;
        }

        public static int arraysToInt(int[] arrays)
        {
            return Array.IndexOf(arrays, 1);
        }

    }
}
