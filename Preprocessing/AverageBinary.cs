using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preprocessing
{
    class AverageBinary
    {
        private Bitmap _input;
        private Bitmap _output;
        public AverageBinary(Bitmap input)
        {
            _input = input;
            _output = new Bitmap(_input.Width, _input.Height);
            _output = ThresholdBinarySequent();
        }

        private Bitmap ThresholdBinarySequent()
        {
            double average = 0;
            for(int x = 0; x < _input.Width; x++)
            {
                for(int y = 0; y < _input.Height; y++)
                {
                    average += _input.GetPixel(x, y).GetBrightness();
                }
            }

            average = average / (_input.Width * _input.Height);
            average = average < .3 ? .3 : average;
            average = average > .7 ? .7 : average;

            for(int x = 0; x < _input.Width; x++)
            {
                for(int y = 0; y < _input.Height; y++)
                {
                    Color color = _input.GetPixel(x, y);
                    if(color.GetBrightness()> average)
                    {
                        _output.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        _output.SetPixel(x, y, Color.Black);
                    }
                }
            }
            return _output;
        }

        public Bitmap Output
        {
            get
            {
                return _output;
            }
        }
    }
}
