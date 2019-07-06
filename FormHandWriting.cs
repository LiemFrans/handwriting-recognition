using BackpropagationNeuralNetwork;
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
        private List<ImageDTO> _dataTesting;
        private string _action;
        private Preprocessing.Preprocessing preprocessing;
        private ProfileProjection.ProfileProjection profileProjection;
        private BackpropagationNeuralNetwork.BackpropagationNeuralNetwork backpropagationNeuralNetwork;

        public FormHandWriting()
        {
            InitializeComponent();
        }

        /// <summary>
        /// FORM PELATIHAN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            imageDTO.PositionOfCharacter = Util.charToIntegerPosition(c);//to get class integer of character (e.g: 'A' is class 0, 'B' is class 1, etc
                            var binaryArrays = Util.digitArr(imageDTO.PositionOfCharacter);
                            imageDTO.ArrayBinaryofClass = binaryArrays;
                            imageDTO.FileName = Path.GetFileName(f);
                            imageList.Images.Add(imageDTO.ClassName, new Bitmap(imageDTO.Raw));
                            _dataTraining.Add(imageDTO);
                        }
                    }
                    setImagetoListView(listViewRealImageTraining, imageList);
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
            List<ListView> inFormListView = new List<ListView>();
            switch (_action)
            {
                case "training" :
                    inFormListView.Add(listViewGrayscallingTraining);
                    inFormListView.Add(listViewGaussianFilteringTraining);
                    inFormListView.Add(listViewBinerisasiTraining);
                    _dataTraining = backgroundPreprocessing(_dataTraining, inFormListView);
                    break;
                case "testing":
                    inFormListView.Add(listViewGrayscallingTesting);
                    inFormListView.Add(listViewGaussianFilteringTesting);
                    inFormListView.Add(listViewBinerisasiTesting);
                    _dataTesting = backgroundPreprocessing(_dataTraining, inFormListView);
                    break;
            }
            return result;
        }

        private void bwLoadingPreprocessing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) MessageBox.Show(e.Error.Message);
            else
            {
                MessageBox.Show("Done");
                switch (_action)
                {
                    case "training":
                        btnOpenImageTraining.Enabled = true;
                        btnFeatureExtractionTraining.Enabled = true;
                        break;
                    case "testing":
                        btnOpenImageTesting.Enabled = true;
                        btnFeatureExtractionTesting.Enabled = true;
                        break;
                }
  
            }
        }

        private List<ImageDTO> backgroundPreprocessing(List<ImageDTO>imageDTOs, List<ListView> inFormListView)
        {
            int lengthGaussianFilter = Convert.ToInt32(numLengthGaussian.Value);
            double weightGaussianFilter = Convert.ToDouble(numWeightGaussian.Value);
            var imageListGrayscalling = new ImageList { ImageSize = new Size(200, 200) };
            var imageListGaussian = new ImageList { ImageSize = new Size(200, 200) };
            var imageListBinary = new ImageList { ImageSize = new Size(200, 200) };
            Parallel.For(0, imageDTOs.Count, i =>
             {
                 ImageDTO imageDTO = imageDTOs[i];
                 preprocessing = new Preprocessing.Preprocessing(imageDTO.Raw, lengthGaussianFilter, weightGaussianFilter);
                 imageDTO.GrayScalling = preprocessing.GrayscalingImage;
                 imageDTO.Gaussian = preprocessing.FilterImage;
                 imageDTO.Binary = preprocessing.AverageBinaryImage;

                 imageDTOs[i] = imageDTO;
             });

            for(int i = 0; i < imageDTOs.Count; i++)
            {
                ImageDTO imageDTO = imageDTOs[i];
                imageListGrayscalling.Images.Add(imageDTO.ClassName, imageDTO.GrayScalling);
                imageListGaussian.Images.Add(imageDTO.ClassName, imageDTO.Gaussian);
                imageListBinary.Images.Add(imageDTO.ClassName, imageDTO.Binary);
            }

            setImagetoListView(inFormListView[0]/*listViewGrayscallingTraining*/, imageListGrayscalling);
            setImagetoListView(inFormListView[1]/*listViewGaussianFilteringTraining*/, imageListGaussian);
            setImagetoListView(inFormListView[2]/*listViewBinerisasiTraining*/, imageListBinary);
            return imageDTOs;
        }

        private void btnPreprocessingTraining_Click(object sender, EventArgs e)
        {
            _action = "training";
            btnPreprocessingTraining.Enabled = false;
            btnOpenImageTraining.Enabled = false;
            bwLoadingPreprocessing.RunWorkerAsync();
        }

        private void btnFeatureExtractionTraining_Click(object sender, EventArgs e)
        {
            dataFiturTraining.ColumnCount = Constants.COLUMNNAME.Length;
            btnOpenImageTraining.Enabled = false;
            btnFeatureExtractionTraining.Enabled = false;
            for(int i = 0; i < Constants.COLUMNNAME.Length; i++)
            {
                dataFiturTraining.Columns[i].Name = Constants.COLUMNNAME[i];
                dataFiturTraining.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            bwExtractionFeature.RunWorkerAsync();
        }

        private void bwExtractionFeature_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = BackgroundExtractionLogicMethod();
        }

        private int BackgroundExtractionLogicMethod()
        {
            int result = 0;
            switch (_action)
            {
                case "training":
                    _dataTraining = backgroundExtractionFeature(_dataTraining, dataFiturTraining);
                    break;
                case "testing":
                    _dataTesting = backgroundExtractionFeature(_dataTesting, dataFiturTesting);
                    break;
            }
            return result;
        }

        private void bwExtractionFeature_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) MessageBox.Show(e.Error.Message);
            else {
                MessageBox.Show("Done");
                switch (_action)
                {
                    case "training":
                        btnOpenImageTraining.Enabled = true;
                        tlpBPNN.Enabled = true;
                        break;
                    case "testing":
                        btnOpenImageTesting.Enabled = true;
                        break;
                }
            }
        }

        private List<ImageDTO> backgroundExtractionFeature(List<ImageDTO> data, DataGridView dataGridView)
        {
            Parallel.For(0, data.Count, i =>
            {
                ImageDTO imageDTO = data[i];
                MomentsHu momentsHu = new MomentsHu(imageDTO.Binary);
                imageDTO.MomentHu = momentsHu.Moments;
                data[i] = imageDTO;
            });
            for(int i = 0; i < data.Count; i++)
            {
                string[] rows = new string[data[i].MomentHu.Length+4];
                rows[0] = data[i].ClassName;
                rows[1] = data[i].FileName;
                rows[2] = data[i].PositionOfCharacter.ToString();
                rows[3] =  string.Join(",",data[i].ArrayBinaryofClass);
                int k = 0;
                for(int j = 4; j < rows.Length; j++)
                {
                    rows[j] = data[i].MomentHu[k].ToString();
                    k++;
                }
                this.Invoke(new MethodInvoker(delegate { dataGridView.Rows.Add(rows); }));
            }
            return data;
        }

        private void numLengthGaussian_ValueChanged(object sender, EventArgs e)
        {
            tbLengthGaussianFilter.Text = numLengthGaussian.Value.ToString();
        }

        private void numWeightGaussian_ValueChanged(object sender, EventArgs e)
        {
            tbWeightGaussianFilter.Text = numWeightGaussian.Value.ToString();
        }

        /// <summary>
        /// END FORM PELATIHAN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///

        /// <summary>
        /// FORM PENGUJIAN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///
        private void btnOpenImageTesting_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    _dataTesting = new List<ImageDTO>();
                    // create image list and fill it 
                    var imageList = new ImageList { ImageSize = new Size(200, 200) };
                    string[] folders = Directory.GetDirectories(fbd.SelectedPath + "\\");
                    foreach (string fd in folders)
                    {
                        string[] files = Directory.GetFiles(fd);
                        foreach (string f in files)
                        {
                            ImageDTO imageDTO = new ImageDTO();
                            imageDTO.Raw = new Bitmap(f);
                            imageDTO.ClassName = Path.GetFileName(fd);
                            char c = imageDTO.ClassName[0];
                            imageDTO.PositionOfCharacter = Util.charToIntegerPosition(c);//to get class integer of character (e.g: 'A' is class 0, 'B' is class 1, etc
                            var binaryArrays = Util.digitArr(imageDTO.PositionOfCharacter);
                            imageDTO.ArrayBinaryofClass = binaryArrays;
                            imageDTO.FileName = Path.GetFileName(f);
                            imageList.Images.Add(imageDTO.ClassName, new Bitmap(imageDTO.Raw));
                            _dataTesting.Add(imageDTO);
                        }
                    }
                    setImagetoListView(listViewRealImageTesting, imageList);
                    System.Windows.Forms.MessageBox.Show("Data Training found: " + _dataTesting.Count.ToString(), "Message");
                }
            }
            btnPreprocessingTesting.Enabled = true;
        }

        private void btnPreprocessingTesting_Click(object sender, EventArgs e)
        {
            _action = "testing";
            btnPreprocessingTesting.Enabled = false;
            btnOpenImageTesting.Enabled = false;
            bwLoadingPreprocessing.RunWorkerAsync();
        }

        private void btnFeatureExtractionTesting_Click(object sender, EventArgs e)
        {
            _action = "testing";
            btnOpenImageTesting.Enabled = false;
            btnFeatureExtractionTesting.Enabled = false;
            dataFiturTesting.ColumnCount = Constants.COLUMNNAME.Length;
            for (int i = 0; i < Constants.COLUMNNAME.Length; i++)
            {
                dataFiturTesting.Columns[i].Name = Constants.COLUMNNAME[i];
                dataFiturTesting.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            bwExtractionFeature.RunWorkerAsync();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            _action = "training BPNN";
            btnTraining.Enabled = false;
            numHiddenNeuron.Enabled = false;
            numLayers.Enabled = false;
            numLearningRate.Enabled = false;
            numMomentum.Enabled = false;
            numMaxEpochs.Enabled = false;
            bwBPNN.RunWorkerAsync();
        }

        /// <summary>
        /// FORM PELARIHAN BPNN RESULT WEIGHT BPNN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void bwBPNN_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = BackgroundBPNNLogicMethod();
        }

        private void bwBPNN_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) MessageBox.Show(e.Error.Message);
            else
            {
                MessageBox.Show("Done");
                switch (_action)
                {
                    case "training BPNN":
                        btnTraining.Enabled = true;
                        numHiddenNeuron.Enabled = true;
                        numLayers.Enabled = true;
                        numLearningRate.Enabled = true;
                        numMomentum.Enabled = true;
                        numMaxEpochs.Enabled = true;
                        tlpTesting.Enabled = true;
                        break;
                }
            }
        }

        private int BackgroundBPNNLogicMethod()
        {
            int result = 0;
            switch (_action)
            {
                case "training BPNN":
                    backgroundBPNNTraining(_dataTraining);
                    break;
            }
            return result;
        }

        private void backgroundBPNNTraining(List<ImageDTO> data)
        {
            int inputNeuron = data[0].MomentHu.Length;
            int hiddenNeuron = Convert.ToInt32(numHiddenNeuron.Value);
            int layerNeuron = Convert.ToInt32(numLayers.Value);
            int outputNeuron = Constants.LENGTH_ARRAYS_BITS;

            backpropagationNeuralNetwork = new BackpropagationNeuralNetwork.BackpropagationNeuralNetwork(inputNeuron, hiddenNeuron, outputNeuron, true);
            int maxEpochs = Convert.ToInt32(numMaxEpochs.Value);
            double learnRate = Convert.ToDouble(numLearningRate.Value);
            double momentum = Convert.ToDouble(numMomentum.Value);

            Console.WriteLine("===============================You Can See this Logs at Console===============================");

            Console.WriteLine("Prepearing Load data from Memory");
            List<double[]> dataTraining = new List<double[]>();
            for(int i = 0; i < data.Count; i++)
            {
                double[] dataRows = new double[inputNeuron+Constants.LENGTH_ARRAYS_BITS];
                for(int j = 0; j < data[i].MomentHu.Length; j++)
                {
                    dataRows[j] = data[i].MomentHu[j];
                }
                int k = 0;
                for(int j = data[i].MomentHu.Length; j< dataRows.Length; j++)
                {
                    dataRows[j] = data[i].ArrayBinaryofClass[k];
                    k++;
                }
                dataTraining.Add(dataRows);
            }

            Console.WriteLine("\nSetting maxEpochs = " + maxEpochs);
            Console.WriteLine("Setting learnRate = " + learnRate.ToString("F2"));
            Console.WriteLine("Setting momentum  = " + momentum.ToString("F2"));

            Console.WriteLine("\nStarting training");
            Layers weights = backpropagationNeuralNetwork.Train(dataTraining.ToArray(), maxEpochs, learnRate, momentum);

            Console.WriteLine("Done");
            Console.WriteLine("\nFinal neural network model weights and biases:\n");

            Console.WriteLine("Panjang Neurons "+weights.NumNeuron);

            this.Invoke(new MethodInvoker(delegate {
                dgViewWeightResult.ColumnCount = weights.NumNeuron;
                for(int i = 0; i < weights.NumNeuron; i++)
                {
                    dgViewWeightResult.Columns[i].Name = "Neuron " + i;
                }
                string[] arrays = new string[weights.NumNeuron];
                for(int i = 0; i < weights.NumNeuron; i++)
                {
                    arrays[i] = weights.Neurons[i].Value.ToString();
                }
                dgViewWeightResult.Rows.Add(arrays);
            })); 
        }
    }
}
