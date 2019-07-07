using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureExtraction.Moments
{
    class ImageAccess
    {
        private Bitmap _input;
        private int _nx;
        private int _ny;
        private int size;
        private int[] _imageArrays;

        public ImageAccess(Bitmap input)
        {
            _input = input;
            _nx = _input.Width;
            _ny = _input.Height;
            _imageArrays = new int[_nx * _ny];
            int k = 0;
            for (int x = 0; x < _nx; x++)
            {
                for (int y = 0; y < _ny; y++)
                {
                    Color color = _input.GetPixel(x, y);
                    Color colorWhite = Color.White;
                    if(color.A == colorWhite.A && color.R == colorWhite.R && color.G == colorWhite.G && color.B == colorWhite.B)
                    {
                        _imageArrays[k++] = 0;
                    }else
                    {
                        _imageArrays[k++] = 1;
                    }
                }
            }
        }



        public double GetPixel(int x, int y)
        {
            int periodx = 2 * _nx - 2;
            int periody = 2 * _ny - 2;
            if (x < 0)
            {
                while (x < 0) x += periodx; //Periodize
                if (x < 0) x = -x; //Symmetrize
            }else if(x >= _nx)
            {
                while (x >= _nx) x -= periodx; //Periodize 
                if (x < 0) x = -x; //Symmetrize
            }

            if (y < 0)
            {
                while (y < 0) y += periody; //Periodize
                if (y >= _ny) y = periody - y; //Symmetrize
            }else if (y >= _ny)
            {
                while (y >= _ny) y -= periody; //Periodize
                if (y < 0) y = -y;
            }
            return _imageArrays[x + y * _nx];
        }
    }
}
