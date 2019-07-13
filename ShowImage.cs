using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace handwriting_recognition
{
    public partial class ShowImage : Form
    {
        public ShowImage(Bitmap bitmap)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Fixed3D;
            WindowState = FormWindowState.Maximized;
            pbImage.Image = bitmap;
            pbImage.MaximumSize = pbImage.Image.Size;
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;

        }
    }
}
