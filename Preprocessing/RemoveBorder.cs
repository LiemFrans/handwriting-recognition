using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preprocessing
{
    class RemoveBorder
    {
        private Bitmap _input;
        private Bitmap _output;
        private int _width;
        private int _height;
        public RemoveBorder(Bitmap input)
        {
            _input = input;
            _width = _input.Width;
            _height = _input.Height;
            _input = removalHorizontal();
            _input = removalVertical();
            _output = _input;
        }

        private Bitmap removalHorizontal()
        {
            Bitmap output = _input;

            for (int x = 0; x < _width; x++)
            {
                int temp = 0;
                for (int y = 0; y < _height; y++)
                {
                    Color color = _input.GetPixel(x, y);
                    Color colorBlack = Color.Black;
                    if (color.A == colorBlack.A && color.R == colorBlack.R && color.G == colorBlack.G && color.B == colorBlack.B)
                    {
                       temp++;
                    }
                }
                if (temp == _height)
                {
                    Color colorWhite = Color.White;
                    for (int y = 0; y < _height; y++)
                    {
                        output.SetPixel(x, y, colorWhite);
                    }
                }
            }
            return output;
        }

        private Bitmap removalVertical()
        {
            Bitmap output = _input;
            for(int y = 0; y < _height; y++)
            {
                int temp = 0;
                for(int x = 0; x < _width; x++)
                {
                    Color color = _input.GetPixel(x, y);
                    Color colorBlack = Color.Black;
                    if (color.A == colorBlack.A && color.R == colorBlack.R && color.G == colorBlack.G && color.B == colorBlack.B)
                    {
                        temp++;
                    }
                }
                if(temp == _width)
                {
                    Color colorWhite = Color.White;
                    for(int x = 0; x < _width; x++)
                    {
                        output.SetPixel(x, y, colorWhite);
                    }
                }
            }
            return output;
        }
        public Bitmap Output { get => _output; }
    }
}
