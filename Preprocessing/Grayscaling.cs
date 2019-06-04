using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preprocessing
{
    public class Grayscaling
    {
        private Bitmap _input;
        private bool _optimizedParallel;
        private Bitmap _output;
        public Grayscaling(Bitmap input, bool optimizedParallel)
        {
            _input = input;
            _optimizedParallel = optimizedParallel;
            Bitmap _output = new Bitmap(input.Width, input.Height);
            if (_optimizedParallel)
            {
                ParallelGrayscaling();
            }
            else
            {
                GrayscalingSequent();
            }
        }
        private void ParallelGrayscaling()
        {
            Parallel.For(0, _input.Width, x =>
            {
                Parallel.For(0, _input.Height, y =>
                {
                    Color pixelColor = _input.GetPixel(x, y);
                    //  0.3 · r + 0.59 · g + 0.11 · b
                    int grey = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                    _output.SetPixel(x, y, Color.FromArgb(pixelColor.A, grey, grey, grey));
                });
            });
        }

        private void GrayscalingSequent()
        {
            for (int x = 0; x < _input.Width; x++)
            {
                for (int y = 0; y < _input.Height; y++)
                {
                    Color pixelColor = _input.GetPixel(x, y);
                    //  0.3 · r + 0.59 · g + 0.11 · b
                    int grey = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                    _output.SetPixel(x, y, Color.FromArgb(pixelColor.A, grey, grey, grey));
                }
            }
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
