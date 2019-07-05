using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handwriting_recognition
{
    class Util
    {
        public int charToIntegerPosition(char c)
        {
            return char.ToUpper(c) - 64;
        }
    }
}
