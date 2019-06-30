using handwriting_recognition.DTO;
using Preprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace handwriting_recognition
{
    public partial class FormHandWriting : Form
    {
        private List<ImageDTO> _dataTraining;
        private string _action;
        private Preprocessing.Preprocessing preprocessing;
        public FormHandWriting()
        {
            InitializeComponent();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
        }


        private void btnProcessVPP_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenImageTraining_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    _dataTraining = new List<ImageDTO>();
                    // create image list and fill it 
                    var imageList = new ImageList { ImageSize = new Size(200, 200) };
                    string[] folders = Directory.GetDirectories(fbd.SelectedPath+"\\");
                    foreach(string fd in folders)
                    {
                        string[] files = Directory.GetFiles(fd);
                        foreach(string f in files)
                        {
                            ImageDTO imageDTO = new ImageDTO();
                            imageDTO.Raw = new Bitmap(f);
                            imageDTO.ClassName = Path.GetFileName(fd);
                            imageDTO.FileName = Path.GetFileName(f);
                            imageList.Images.Add(imageDTO.ClassName, new Bitmap(imageDTO.Raw));
                            _dataTraining.Add(imageDTO);
                        }
                    }
                    setImagetoListView(listViewRealImage, imageList);
                    System.Windows.Forms.MessageBox.Show("Data Training found: " + _dataTraining.Count.ToString(), "Message");
                }
            }
            btnPreprocessingTraining.Enabled = true;
            numLengthGaussian.Enabled = true;
            numWeightGaussian.Enabled = true;
        }

        private void setImagetoListView (ListView listView, ImageList imageList)
        {
            imageList.ImageSize = new Size(48, 48);
            listView.View = View.LargeIcon;
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                listView.Invoke(new MethodInvoker(delegate { listView.Items.Add(new ListViewItem { ImageIndex = i }); }));
            }
            listView.Invoke(new MethodInvoker(delegate { listView.LargeImageList = imageList; }));
        }

        private void bwLoadingPreprocessing_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = BackgroundProcessLogicMethod();
        }
        private int BackgroundProcessLogicMethod()
        {
            int result = 0;
            MessageBox.Show("I was doing some work in the background.");
            backgroundPreprocessing();
            return result;
        }

        private void bwLoadingPreprocessing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) MessageBox.Show(e.Error.Message);
            else MessageBox.Show(e.Result.ToString());
        }

        private void backgroundPreprocessing()
        {
            int lengthGaussianFilter = Convert.ToInt32(numLengthGaussian.Value);
            double weightGaussianFilter = Convert.ToDouble(numWeightGaussian.Value);
            var imageListGrayscalling = new ImageList { ImageSize = new Size(200, 200) };
            var imageListGaussian = new ImageList { ImageSize = new Size(200, 200) };
            var imageListBinary = new ImageList { ImageSize = new Size(200, 200) };
            Parallel.For(0, _dataTraining.Count, i =>
             {
                 ImageDTO imageDTO = _dataTraining[i];
                 preprocessing = new Preprocessing.Preprocessing(imageDTO.Raw, lengthGaussianFilter, weightGaussianFilter);
                 imageDTO.GrayScalling = preprocessing.GrayscalingImage;
                 imageDTO.Gaussian = preprocessing.FilterImage;
                 imageDTO.Binary = preprocessing.AverageBinaryImage;

                 imageListGrayscalling.Images.Add(imageDTO.ClassName, imageDTO.GrayScalling);
                 imageListGaussian.Images.Add(imageDTO.ClassName, imageDTO.Gaussian);
                 imageListBinary.Images.Add(imageDTO.ClassName, imageDTO.Binary);
                 _dataTraining[i] = imageDTO;
             });
            setImagetoListView(listViewGrayscalling, imageListGrayscalling);
            setImagetoListView(listViewGaussianFiltering, imageListGaussian);
            setImagetoListView(listViewBinerisasi, imageListBinary);
            btnProfileProjection.Invoke(new MethodInvoker(delegate { btnProfileProjection.Enabled = true; }));
        }

        private void btnPreprocessingTraining_Click(object sender, EventArgs e)
        {
            bwLoadingPreprocessing.RunWorkerAsync();
        }

        private void btnProfileProjection_Click(object sender, EventArgs e)
        {

        }
    }
}
