using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preprocessing
{
    class ThresholdBinary
    {
        private Bitmap _input;
        private Bitmap _output;
        private int _threshold;
        private bool _optimizedParallel;
        public ThresholdBinary(Bitmap input, int threshold = 28, bool optimizedParallel = false)
        {
            _input = input;
            _threshold = threshold;
            _optimizedParallel = optimizedParallel;
            _output = new Bitmap(_input.Width, _input.Height);
            if (_optimizedParallel)
            {
                _output = ThresholdBinaryParallel();
            }
            else
            {
                _output = ThresholdBinarySequent();
            }

        }

        private Bitmap ThresholdBinaryParallel()
        {
            Parallel.For(0, _input.Width, x =>
            {
                Parallel.For(0, _input.Height, y =>
                {
                    Color pixelColor = _input.GetPixel(x, y);
                    int binary;
                    if(pixelColor.A < _threshold && pixelColor.R < _threshold && pixelColor.G < _threshold && pixelColor.B < _threshold)
                    {
                        binary = 0;
                    }
                    else
                    {
                        binary = 1;
                    }

                    _output.SetPixel(x, y, Color.FromArgb(binary, binary, binary, binary));
                });
            });
            return _output;
        }

        private Bitmap ThresholdBinarySequent()
        {
            for(int x = 0; x <_input.Width; x++)
            {
                for(int y = 0; y < _input.Height; y++)
                {
                    Color pixelColor = _input.GetPixel(x, y);
                    int binary;
                    if (pixelColor.A < _threshold && pixelColor.R < _threshold && pixelColor.G < _threshold && pixelColor.B < _threshold)
                    {
                        binary = 0;
                    }
                    else
                    {
                        binary = 1;
                    }

                    _output.SetPixel(x, y, Color.FromArgb(binary, binary, binary, binary));
                }
            }
            return _output;
        }

        private Bitmap Output
        {
            get
            {
                return _output;
            }
        }
    }
}
