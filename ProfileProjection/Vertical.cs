using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileProjection
{
    class Vertical
    {
        private Bitmap _input;
        private List<Bitmap> _output;
        private int _threshold;//threshold projection to know cut image
        private List<int[]> _indexOfYSlices; 
        public Vertical(Bitmap input, int threshold)
        {
            _threshold = threshold;
            _input = input;
            int[] coordinatY = VerticalProjection();
            _output = new List<Bitmap>();
            List<int> temp = new List<int>();
            _indexOfYSlices = new List<int[]>();
            for(int y = 0; y < coordinatY.Length; y++)
            {
                if (coordinatY[y] > _threshold && coordinatY[y] != _input.Width)
                {
                    temp.Add(y);
                }
                else
                {
                    if (temp.Count > 0)
                    {
                        _indexOfYSlices.Add(temp.ToArray());
                    }
                    temp = new List<int>();
                }
            }
            if (temp.Count > 0)
            {
                _indexOfYSlices.Add(temp.ToArray());
            }
            foreach(int[] coordinates in _indexOfYSlices)
            {
                if (coordinates.Length > 0)
                {
                    Bitmap temporaryImagesSaves = new Bitmap(_input.Width, coordinates.Length);
                    for (int y = 0; y < coordinates.Length; y++)
                    {
                        for (int x = 0; x < _input.Width; x++)
                        {
                            temporaryImagesSaves.SetPixel(x, y, _input.GetPixel(x, coordinates[y]));
                        }
                    }
                    _output.Add(temporaryImagesSaves);
                }
            }
        }

        private int[] VerticalProjection()
        {
            int[] verticalProjection = new int[_input.Height];
            for (int y = 0; y < _input.Height; y++)
            {
                for (int x = 0; x < _input.Width; x++)
                {
                    Color color = _input.GetPixel(x, y);
                    Color colorBlack = Color.Black;
                    if (color.A == colorBlack.A && color.R == colorBlack.R && color.G == colorBlack.G && color.B == colorBlack.B)
                    {
                        verticalProjection[y]++;
                    }
                }
            }
            return verticalProjection;
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
