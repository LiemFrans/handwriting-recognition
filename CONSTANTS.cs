using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handwriting_recognition
{
    class Constants
    {
        public static char[] ALPHA = new char[0];

        public static readonly string[] COLUMNNAME = { "ClassNames", "FileName", "Position of Character", "Arrays of Class", "Moments Hu 0", "Moments Hu 1", "Moments Hu 2", "Moments Hu 3", "Moments Hu 4", "Moments Hu 5", "Moments Hu 6" };

        public static int LENGTH_ARRAYS_BITS = ALPHA.Length;

        public static readonly int FIX_WIDTH = 200;

        public static readonly int FIX_HEIGHT = 200;
    }
}
