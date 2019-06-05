using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureExtraction
{
    public class ProfileProjection
    {
        private Bitmap _input;
        private int[] _projectionFeature;
        public ProfileProjection(Bitmap input)
        {
            _input = input;

            _projectionFeature = new int[_input.Width + _input.Height];
            var verticalProjection = VerticalProjection();
            var horizontalProjection = HorizontalProjection();
            Array.Copy(verticalProjection, _projectionFeature, verticalProjection.Length);
            Array.Copy(horizontalProjection, 0, _projectionFeature, verticalProjection.Length, horizontalProjection.Length);
        }

        public int[] ProjectionFeature { get => _projectionFeature; }

        private int[] HorizontalProjection()
        {
            int[] horizontalProjection = new int[_input.Width];
            for (int x = 0; x < _input.Width; x++)
            {
                for(int y = 0; y < _input.Height; y++)
                {
                    Color color = _input.GetPixel(x, y);
                    if (color == Color.Black)
                    {
                        horizontalProjection[x]++;
                    }
                }
            }
            return horizontalProjection;
        }

        private int[] VerticalProjection()
        {
            int[] verticalProjection = new int[_input.Height];
            for(int y = 0; y < _input.Height; y++)
            {
                for(int x = 0; x < _input.Width; x++)
                {
                    Color color = _input.GetPixel(x, y);
                    if(color == Color.Black)
                    {
                        verticalProjection[y]++;
                    }
                }
            }
            return verticalProjection;
        }

    }
}
