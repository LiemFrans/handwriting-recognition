using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileProjection
{
    public class ProfileProjection
    {
        private Bitmap _input;
        private Bitmap[] _resultImageAfterSliceVetically;
        private List<Bitmap> _resultImageAfterSliceHorizontally;
        public ProfileProjection(Bitmap input, int thresholdVerticalByPercentage, int thresholdHorizontalByPercentage)
        {
            _input = input;
            int thresholdVertical = (thresholdVerticalByPercentage / 100) * input.Width;
            var verticalProjection = new Vertical(_input, thresholdVertical);
            _resultImageAfterSliceHorizontally = new List<Bitmap>();
            _resultImageAfterSliceVetically = verticalProjection.Output;
            foreach(Bitmap image in _resultImageAfterSliceVetically)
            {
                int thresholdHorizontal = (thresholdHorizontalByPercentage / 100) * image.Height;
                var horizontalProjection = new Horizontal(image, thresholdHorizontal);
                var horizontalProjectionImage = horizontalProjection.Output;
                _resultImageAfterSliceHorizontally.AddRange(horizontalProjection.Output);
            }
        }

        public Bitmap[] ResultImageAfterSliceVertically
        {
            get
            {
                return _resultImageAfterSliceVetically;
            }
        }
        public Bitmap[] ResultImageAfterSliceHorizontally
        {
            get
            {
                return _resultImageAfterSliceHorizontally.ToArray();
            }
        }

    }
}
