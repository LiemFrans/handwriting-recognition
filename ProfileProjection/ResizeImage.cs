using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileProjection
{
    public class ResizeImage
    {
        private Bitmap _input;
        private int _width;
        private int _height;
        private Bitmap _output;
        public ResizeImage(Bitmap input, int width, int height)
        {
            _input = input;
            _width = width;
            _height = height;
            _output = resizeImage();
        }

        public Bitmap Output { get => _output;  }

        private Bitmap resizeImage()
        {
            int width = _width;
            int height = _height;
            Bitmap image = _input;
            var destRect = new Rectangle(0, 0, width, height);
            var output = new Bitmap(width, height);

            output.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(output))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return output;
        }
    }
}
