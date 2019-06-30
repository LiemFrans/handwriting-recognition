using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preprocessing
{
    public class Preprocessing
    {
        private Bitmap _input;
        private Bitmap _output;
        private int _lengthGaussianFilter;
        private double _weightGaussianFilter;
        private Bitmap _grayscalingImage;
        private Bitmap _filteringImage;
        private Bitmap _averageBinaryImage;

        public Preprocessing(Bitmap input, int lengthGaussianFilter, double weightGaussianFilter)
        {
            _input = input;
            _lengthGaussianFilter = lengthGaussianFilter;
            _weightGaussianFilter = weightGaussianFilter;

            var grayscaling = new Grayscaling(_input);
            _grayscalingImage = grayscaling.Output;

            var filtering = new GaussianFiltering(_grayscalingImage, lengthGaussianFilter, weightGaussianFilter);
            _filteringImage = filtering.Output;

            var averageBinary = new AverageBinary(_filteringImage);
            _averageBinaryImage = averageBinary.Output;

            _output = _averageBinaryImage;
        }

        public Bitmap Output
        {
            get
            {
                return _output;
            }
        }

        public Bitmap GrayscalingImage
        {
            get
            {
                return _grayscalingImage;
            }
        }

        public Bitmap FilterImage
        {
            get
            {
                return _filteringImage;
            }
        }

        public Bitmap AverageBinaryImage
        {
            get
            {
                return _averageBinaryImage;
            }
        }
    }
}
