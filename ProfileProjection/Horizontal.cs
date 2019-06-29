using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileProjection
{
    class Horizontal
    {
        private Bitmap _input;
        private List<Bitmap> _output;
        private int _threshold;//threshold projection to know cut image
        private List<int[]> _indexOfXSlices;
        public Horizontal (Bitmap input, int threshold)
        {
            _threshold = threshold;
            _input = input;
            int[] coordinatX = HorizontalProjection();
            _output = new List<Bitmap>();
            List<int> temp = new List<int>();
            _indexOfXSlices = new List<int[]>();
            for(int x = 0; x < coordinatX.Length; x++)
            {
                if(coordinatX[x]> _threshold && coordinatX[x] != _input.Height)
                {
                    temp.Add(x);
                }
                else
                {
                    if (temp.Count > 0)
                    {
                        _indexOfXSlices.Add(temp.ToArray());
                    }
                    temp = new List<int>();
                }
            }
            if (temp.Count > 0)
            {
                _indexOfXSlices.Add(temp.ToArray());
            }
            foreach(int[] coordinates in _indexOfXSlices)
            {
                if(coordinates.Length > 0)
                {
                    Bitmap temporaryImagesSaves = new Bitmap(coordinates.Length, _input.Height);
                    for(int y = 0; y < _input.Height; y++)
                    {
                        for(int x = 0; x < coordinates.Length; x++)
                        {
                            temporaryImagesSaves.SetPixel(x, y, _input.GetPixel(coordinates[x], y));
                        }
                    }
                    _output.Add(temporaryImagesSaves);
                }
            }
        }
        private int[] HorizontalProjection()
        {
            int[] horizontalProjection = new int[_input.Width];
            for (int x = 0; x < _input.Width; x++)
            {
                for (int y = 0; y < _input.Height; y++)
                {
                    Color color = _input.GetPixel(x, y);
                    Color colorBlack = Color.Black;
                    if (color.A == colorBlack.A && color.R == colorBlack.R && color.G == colorBlack.G && color.B == colorBlack.B)
                    {
                        horizontalProjection[x]++;
                    }
                }
            }
            return horizontalProjection;
        }

        public Bitmap[] Output
        {
            get
            {
                return _output.ToArray();
            }
        }
    }
}
