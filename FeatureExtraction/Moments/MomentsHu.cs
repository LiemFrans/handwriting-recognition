using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureExtraction.Moments
{
    public class MomentsHu
    {
        private Bitmap _input;
        private ImageAccess _imageAccess;
        private double _m00;
        private int _nx;
        private int _ny;
        private double _xg;
        private double _yg;

        private double[] _moments;

        public MomentsHu(Bitmap input)
        {
            _input = input;
            _imageAccess = new ImageAccess(_input);

            _moments = new double[7];

            _m00 = GetM(0.0, 0.0);

            _nx = _input.Width;
            _ny = _input.Height;

            _xg = GetM(1.0, 0.0) / _m00;
            _yg = GetM(0.0, 1.0) / _m00;

            HusInvariantMoment();
        }

        private double GetM(double p, double q) {
            double value;
            double m = 0;
            for (int x = 0; x < _input.Width; x++)
            {
                for (int y = 0; y < _input.Height; y++)
                {
                    value = _imageAccess.GetPixel(x, y);
                    m += Math.Pow(x, p) * Math.Pow(y, q) * value;
                }
            }
            return m;
        }
        private double GetN(double p, double q)
        {
            double n = 0;
            double value;
            for(int x = 0; x < _nx; x++)
            {
                for(int y = 0; y< _ny; y++)
                {
                    value = _imageAccess.GetPixel(x, y);
                    n += Math.Pow((x - _xg), p) * Math.Pow((y - _yg), q) * value;
                }
            }
            return n;
        }
        private double GetMi(double p, double q){
            double gamma = (p + q) / 2 + 1;
            return (GetN(p, q) / (Math.Pow(GetN(0.0, 0.0), gamma)));

        }
        private void HusInvariantMoment()
        {
            _moments[0] = GetMi(2.0, 0.0) + GetMi(0.0, 2.0);
            _moments[1] = (float)Math.Pow((GetMi(2, 0) - GetMi(0, 2)), 2) + (float)Math.Pow((2 * GetMi(1, 1)), 2);
            _moments[2] = (float)Math.Pow((GetMi(3, 0) - 3 * GetMi(1, 2)), 2) + (float)Math.Pow((3 * GetMi(2, 1) - GetMi(0, 3)), 2);
            _moments[3] = (float)Math.Pow((GetMi(3, 0) + GetMi(1, 2)), 2) + (float)Math.Pow((GetMi(2, 1) + GetMi(0, 3)), 2);
            _moments[4] = (GetMi(3, 0) - 3 * GetMi(1, 2)) * (GetMi(3, 0) + GetMi(1, 2)) * ((float)Math.Pow((GetMi(3, 0) + GetMi(1, 2)), 2) - 3 * (float)Math.Pow((GetMi(2, 1) + GetMi(0, 3)), 2)) + (3 * GetMi(2, 1) - GetMi(0, 3)) * (GetMi(2, 1) + GetMi(0, 3)) * (3 * (float)Math.Pow((GetMi(0, 3) + GetMi(1, 2)), 2) - (float)Math.Pow((GetMi(2, 1) + GetMi(0, 3)), 2));
            _moments[5] = (GetMi(2, 0) - GetMi(0, 2)) * ((float)Math.Pow((GetMi(3, 0) + GetMi(1, 2)), 2)) - ((float)Math.Pow((GetMi(2, 1) + GetMi(0, 3)), 2)) + 4 * GetMi(1, 1) * (GetMi(3, 0) + GetMi(1, 2)) * (GetMi(2, 1) + GetMi(0, 3));
            _moments[6] = (3 * GetMi(2, 1) - GetMi(0, 3)) * (GetMi(3, 0) + GetMi(1, 2)) * (float)Math.Pow(((float)Math.Pow((GetMi(3, 0) + GetMi(1, 2)), 2) - 3 * (GetMi(2, 1) + GetMi(0, 3))), 2) + (GetMi(3, 0) - 3 * GetMi(1, 2)) * (GetMi(2, 1) + GetMi(0, 3)) * (3 * ((float)Math.Pow((GetMi(3, 0) + GetMi(1, 2)), 2)) - ((float)Math.Pow((GetMi(2, 1) + GetMi(0, 3)), 2)));
        }

        public double[] Moments
        {
            get
            {
                return _moments;
            }
        }
    }
}
