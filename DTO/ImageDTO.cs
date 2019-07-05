using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handwriting_recognition.DTO
{
    public class ImageDTO
    {
        private Bitmap _raw;
        private Bitmap _grayScalling;
        private Bitmap _binary;
        private Bitmap _gaussian;
        private double[] _momentHu;
        private string _className;
        private int _positionOfCharacter;
        private string _fileName;
        private Bitmap[] _horizontalCutt;
        private Bitmap[] _verticalCutt;

        public Bitmap Raw { get => _raw; set => _raw = value; }
        public Bitmap GrayScalling { get => _grayScalling; set => _grayScalling = value; }
        public Bitmap Binary { get => _binary; set => _binary = value; }
        public Bitmap Gaussian { get => _gaussian; set => _gaussian = value; }
        public double[] MomentHu { get => _momentHu; set => _momentHu = value; }
        public string ClassName { get => _className; set => _className = value; }
        public string FileName { get => _fileName; set => _fileName = value; }
        public Bitmap[] HorizontalCutt { get => _horizontalCutt; set => _horizontalCutt = value; }
        public Bitmap[] VerticalCutt { get => _verticalCutt; set => _verticalCutt = value; }
        public int PositionOfCharacter { get => _positionOfCharacter; set => _positionOfCharacter = value; }
    }
}
