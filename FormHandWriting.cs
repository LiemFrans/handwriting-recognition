using FeatureExtraction.Moments;
using handwriting_recognition.DTO;
using Preprocessing;
using ProfileProjection;
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
        private ProfileProjection.ProfileProjection profileProjection;
        public FormHandWriting()
        {
            InitializeComponent();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
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
                            char c = imageDTO.ClassName[0];
                            imageDTO.PositionOfCharacter = new Util().charToIntegerPosition(c);//to get class integer of character (e.g: 'A' is class 0, 'B' is class 1, etc
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
            backgroundPreprocessing();
            return result;
        }

        private void bwLoadingPreprocessing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) MessageBox.Show(e.Error.Message);
            else MessageBox.Show("Done");
        }

        private void backgroundPreprocessing()
        {
            this.Invoke(new MethodInvoker(delegate {
                btnPreprocessingTraining.Enabled = false;
                btnOpenImage.Enabled = false;
            }));
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


                 _dataTraining[i] = imageDTO;
             });

            for(int i = 0; i < _dataTraining.Count; i++)
            {
                ImageDTO imageDTO = _dataTraining[i];
                imageListGrayscalling.Images.Add(imageDTO.ClassName, imageDTO.GrayScalling);
                imageListGaussian.Images.Add(imageDTO.ClassName, imageDTO.Gaussian);
                imageListBinary.Images.Add(imageDTO.ClassName, imageDTO.Binary);
            }

            setImagetoListView(listViewGrayscalling, imageListGrayscalling);
            setImagetoListView(listViewGaussianFiltering, imageListGaussian);
            setImagetoListView(listViewBinerisasi, imageListBinary);
            this.Invoke(new MethodInvoker(delegate {
                btnOpenImage.Enabled = true;
            }));
            btnFeatureExtractionTraining.Invoke(new MethodInvoker(delegate { btnFeatureExtractionTraining.Enabled = true; }));
        }

        private void btnPreprocessingTraining_Click(object sender, EventArgs e)
        {
            bwLoadingPreprocessing.RunWorkerAsync();
        }

        private void btnFeatureExtractionTraining_Click(object sender, EventArgs e)
        {
            dataFiturTraining.ColumnCount = 10;
            string[] columnName = { "ClassNames", "FileName", "Position of Character", "Moments Hu 0", "Moments Hu 1", "Moments Hu 2", "Moments Hu 3", "Moments Hu 4", "Moments Hu 5", "Moments Hu 6" };
            for(int i = 0; i < columnName.Length; i++)
            {
                dataFiturTraining.Columns[i].Name = columnName[i];
                dataFiturTraining.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            bwExtractionFeatureTraining.RunWorkerAsync();
        }

        private void bwExtractionFeatureTraining_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = BackgroundExtractionLogicMethod();
        }
        private int BackgroundExtractionLogicMethod()
        {
            int result = 0;
            backgroundExtractionFeature(_dataTraining);
            return result;
        }

        private void bwExtractionFeatureTraining_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) MessageBox.Show(e.Error.Message);
            else MessageBox.Show("Done");
        }

        private void backgroundExtractionFeature(List<ImageDTO> data)
        {
            btnOpenImage.Invoke(new MethodInvoker(delegate { btnOpenImage.Enabled = false; }));
            btnFeatureExtractionTraining.Invoke(new MethodInvoker(delegate { btnFeatureExtractionTraining.Enabled = false; }));
            Parallel.For(0, data.Count, i =>
            {
                ImageDTO imageDTO = data[i];
                MomentsHu momentsHu = new MomentsHu(imageDTO.Binary);
                imageDTO.MomentHu = momentsHu.Moments;
                data[i] = imageDTO;
            });
            for(int i = 0; i < data.Count; i++)
            {
                string[] rows = new string[data[i].MomentHu.Length+3];
                rows[0] = data[i].ClassName;
                rows[1] = data[i].FileName;
                rows[2] = data[i].PositionOfCharacter.ToString();
                int k = 0;
                for(int j = 3; j < rows.Length; j++)
                {
                    rows[j] = data[i].MomentHu[k].ToString();
                    k++;
                }
                dataFiturTraining.Invoke(new MethodInvoker(delegate { dataFiturTraining.Rows.Add(rows); }));
            }
            btnOpenImage.Invoke(new MethodInvoker(delegate { btnOpenImage.Enabled = true; }));
        }
    }
}
