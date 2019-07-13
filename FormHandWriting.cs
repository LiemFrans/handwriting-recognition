﻿using BackpropagationNeuralNetwork;
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
        private ImageDTO _dataParagraph;
        private List<ImageDTO> _sliceOfParagraph;
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
                    List<string> classNames = new List<string>();
                    foreach (string fd in folders)
                    {
                        string[] files = Directory.GetFiles(fd);
                        foreach(string f in files)
                        {
                            ImageDTO imageDTO = new ImageDTO();
                            imageDTO.Raw = new Bitmap(f);
                            imageDTO.ClassName = Path.GetFileName(fd);
                            char c = imageDTO.ClassName[0];
                            imageDTO.PositionOfCharacter = Util.charToIntegerPosition(c);//to get class integer of character (e.g: 'A' is class 0, 'B' is class 1, etc
                            var binaryArrays = Util.intToArrays(imageDTO.PositionOfCharacter);
                            imageDTO.ArrayBinaryofClass = binaryArrays;
                            imageDTO.FileName = Path.GetFileName(f);
                            imageList.Images.Add(imageDTO.ClassName, new Bitmap(imageDTO.Raw));
                            classNames.Add(imageDTO.ClassName);
                            _dataTraining.Add(imageDTO);
                        }
                    }
                    setImagetoListView(listViewRealImageTraining, imageList, classNames.ToArray());
                    System.Windows.Forms.MessageBox.Show("Data Training found: " + _dataTraining.Count.ToString(), "Message");
                }
            }
            btnPreprocessingTraining.Enabled = true;
            numLengthGaussian.Enabled = true;
            numWeightGaussian.Enabled = true;
        }

        private void setImagetoListView (ListView listView, ImageList imageList, string[] classNames)
        {
            imageList.ImageSize = new Size(48, 48);
            listView.View = View.LargeIcon;
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                listView.Invoke(new MethodInvoker(delegate { listView.Items.Add(new ListViewItem { ImageIndex = i, Text = classNames[i] }); }));
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
                 imageDTO.Binary = preprocessing.RemoveBorderImage;

                 imageDTOs[i] = imageDTO;
             });
            List<string> classNames = new List<string>();
            for(int i = 0; i < imageDTOs.Count; i++)
            {
                ImageDTO imageDTO = imageDTOs[i];
                imageListGrayscalling.Images.Add(imageDTO.ClassName, imageDTO.GrayScalling);
                imageListGaussian.Images.Add(imageDTO.ClassName, imageDTO.Gaussian);
                imageListBinary.Images.Add(imageDTO.ClassName, imageDTO.Binary);
                classNames.Add(imageDTO.ClassName);
            }

            setImagetoListView(inFormListView[0]/*listViewGrayscallingTraining*/, imageListGrayscalling, classNames.ToArray());
            setImagetoListView(inFormListView[1]/*listViewGaussianFilteringTraining*/, imageListGaussian, classNames.ToArray());
            setImagetoListView(inFormListView[2]/*listViewBinerisasiTraining*/, imageListBinary, classNames.ToArray());
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
            tbLengthGaussianFilterParagraph.Text = numLengthGaussian.Value.ToString();
        }

        private void numWeightGaussian_ValueChanged(object sender, EventArgs e)
        {
            tbWeightGaussianFilterParagraph.Text = numWeightGaussian.Value.ToString();
        }

        /// <summary>
        /// END FORM PELATIHAN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///


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
                        tlpPengenalanParagraph.Enabled = true;
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

            backpropagationNeuralNetwork = new BackpropagationNeuralNetwork.BackpropagationNeuralNetwork(inputNeuron, hiddenNeuron, outputNeuron, false);
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
            if (checkDisplayWeight.Checked)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    dgViewWeightResult.ColumnCount = weights.NumNeuron;
                    for (int i = 0; i < weights.NumNeuron; i++)
                    {
                        dgViewWeightResult.Columns[i].Name = "Neuron " + i;
                    }
                    string[] arrays = new string[weights.NumNeuron];
                    for (int i = 0; i < weights.NumNeuron; i++)
                    {
                        arrays[i] = weights.Neurons[i].Value.ToString();
                    }
                    dgViewWeightResult.Rows.Add(arrays);
                }));
            }
        }

    /// <summary>
    ///  Testing Paragraph
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void btnOpenImageParagraph_Click(object sender, EventArgs e)
        {
            btnFeatureExtractionParagraph.Enabled = false;
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(dlg.FileName);
                    _dataParagraph = new ImageDTO();
                    _dataParagraph.Raw = bitmap;
                    _dataParagraph.ClassName = "Paragraph";
                    _dataParagraph.FileName = dlg.FileName;
                    btnPreprocessingParagraph.Enabled = true;
                    btnShowRealImage.Enabled = true;
                }
            }
        }

        private void btnPreprocessingParagraph_Click(object sender, EventArgs e)
        {
            _action = "preprocessing Paragraph";
            btnPreprocessingParagraph.Enabled = false;
            btnOpenImageParagraph.Enabled = false;
            bwParagraph.RunWorkerAsync();
        }

        private void bwParagraph_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = BackgroundLogicParagraph();
        }

        private void bwParagraph_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) MessageBox.Show(e.Error.Message);
            else
            {
                MessageBox.Show("Done");
                switch (_action)
                {
                    case "preprocessing Paragraph":
                        numHorizontally.Enabled = true;
                        numVertically.Enabled = true;                     
                            btnProfileProjection.Enabled = true;
                        btnShowImageBinary.Enabled = true;
                        btnShowImageGaussianFiltering.Enabled = true;
                        btnShowImageGrayscalling.Enabled = true;
                        break;
                    case "Profile Projection Paragraph":
                        btnFeatureExtractionParagraph.Enabled = true;
                        break;
                    case "Feature Extraction Paragraph":
                        btnTestingDataParagraph.Enabled = true;
                        tlpParagraph.Enabled = true;
                        tlpPengenalanParagraph.Enabled = true;
                        break;
                    case "Feature Extraction":
                        btnFeatureExtractionParagraph.Enabled = true;
                        break;
                }
            }
        }

        private int BackgroundLogicParagraph()
        {
            int result = 0;
            switch (_action)
            {
                case "preprocessing Paragraph":
                    _dataParagraph = backgroundProcessingParagraph(_dataParagraph);
                    break;
                case "Profile Projection Paragraph":
                    _sliceOfParagraph = profileProjectionProcess(_dataParagraph);
                    break;
                case "Feature Extraction Paragraph":
                    _sliceOfParagraph = backgroundExtractionFeature(_sliceOfParagraph, dataFiturParagraf);
                    break;
            }
            return result;
        }

        private ImageDTO backgroundProcessingParagraph(ImageDTO data)
        {
            Bitmap imageRaw = data.Raw;
            var lengthGaussianFilter = Convert.ToInt32(numLengthGaussian.Value);
            var weightGaussianFilter = Convert.ToInt32(numWeightGaussian.Value);
            preprocessing = new Preprocessing.Preprocessing(imageRaw, lengthGaussianFilter, weightGaussianFilter);

            data.GrayScalling = preprocessing.GrayscalingImage;
            data.Gaussian = preprocessing.FilterImage;
            data.Binary = preprocessing.RemoveBorderImage;

            var imageListGrayscalling = new ImageList { ImageSize = new Size(256, 256) };
            var imageListGaussian = new ImageList { ImageSize = new Size(256, 256) };
            var imageListBinary = new ImageList { ImageSize = new Size(256, 256) };

            imageListGrayscalling.Images.Add(data.ClassName, data.GrayScalling);
            imageListGaussian.Images.Add(data.ClassName, data.Gaussian);
            imageListBinary.Images.Add(data.ClassName, data.Binary);
            var classNames = new List<string>();
            classNames.Add(data.ClassName);

            return data;
        }

        private List<ImageDTO> profileProjectionProcess(ImageDTO data)
        {
            int vertical = Convert.ToInt32(numVertically.Value);
            int horizontal = Convert.ToInt32(numHorizontally.Value);
            Bitmap bitmap = data.Binary;
            profileProjection = new ProfileProjection.ProfileProjection(bitmap, vertical, horizontal);

            var verticallyImage = profileProjection.ResultImageAfterSliceVertically;
            var horizontalImage = profileProjection.ResultImageAfterSliceHorizontally;

            var imageListVertical = new ImageList { ImageSize = new Size(256,256) };
            List<string> classNamesVertically = new List<string>();
            int i = 0;
            foreach(Bitmap v in verticallyImage)
            {
                imageListVertical.Images.Add(v);
                classNamesVertically.Add(i.ToString());
                i++;
            }

            var imageListHorizontal = new ImageList { ImageSize = new Size(200, 200) };

            List<ImageDTO> imageSlice = new List<ImageDTO>();
            List<string> classNamesHorizontally = new List<string>();
            i = 0;

            foreach (Bitmap h in horizontalImage)
            {
                imageListHorizontal.Images.Add(h);
                ImageDTO imageDTO = new ImageDTO();
                imageDTO.Binary = h;
                imageDTO.ClassName = i.ToString();
                imageDTO.FileName = i.ToString();
                imageDTO.PositionOfCharacter = i;
                imageDTO.ArrayBinaryofClass = new int[] { i };
                imageSlice.Add(imageDTO);
                classNamesHorizontally.Add(i.ToString());
                i++;
            }

            setImagetoListView(listViewVertically, imageListVertical, classNamesVertically.ToArray());
            setImagetoListView(listViewHorizontally, imageListHorizontal, classNamesHorizontally.ToArray());
            return imageSlice;
        }

        private void btnFeatureExtractionParagraph_Click(object sender, EventArgs e)
        {
            dataFiturParagraf.ColumnCount = Constants.COLUMNNAME.Length;
            btnFeatureExtractionParagraph.Enabled = false;
            for (int i = 0; i < Constants.COLUMNNAME.Length; i++)
            {
                dataFiturParagraf.Columns[i].Name = Constants.COLUMNNAME[i];
                dataFiturParagraf.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            _action = "Feature Extraction Paragraph";
            bwParagraph.RunWorkerAsync();
        }

        private void btnProfileProjection_Click(object sender, EventArgs e)
        {
            _action = "Profile Projection Paragraph";
            btnProfileProjection.Enabled = false;
            bwParagraph.RunWorkerAsync();
        }

        private void btnTestingDataParagraph_Click(object sender, EventArgs e)
        {
            var data = _sliceOfParagraph;
            Console.WriteLine("Prepearing Load data from Memory");
            List<int> predicates = new List<int>();
            int inputNeuron = data[0].MomentHu.Length;
            for (int i = 0; i < data.Count; i++)
            {
                double[] dataRows = new double[inputNeuron];
                for (int j = 0; j < data[i].MomentHu.Length; j++)
                {
                    dataRows[j] = data[i].MomentHu[j];
                }
                int predicate = backpropagationNeuralNetwork.Predicate(dataRows);

                predicates.Add(predicate);
            }

            var imageListTesting = new ImageList { ImageSize = new Size(200, 200) };
            string[] arrayResults = new string[predicates.Count];
            for (int i = 0; i < predicates.Count; i++)
            {
                ImageDTO imageDTO = data[i];
                imageListTesting.Images.Add(imageDTO.ClassName, imageDTO.Binary);
                arrayResults[i] = "index "+ imageDTO.ClassName + ", predicate = " + Util.integerToChar(predicates[i]);
            }
            setImagetoListView(listViewParagraph, imageListTesting, arrayResults);
            btnTestingDataParagraph.Enabled = true;
        }

        private void btnShowImageGrayscalling_Click(object sender, EventArgs e)
        {
            var newImage = new Bitmap(_dataParagraph.GrayScalling);
            var newForm = new ShowImage(newImage);

            newForm.Show();
        }

        private void btnShowImageGaussianFiltering_Click(object sender, EventArgs e)
        {
            var newImage = new Bitmap(_dataParagraph.Gaussian);
            var newForm = new ShowImage(newImage);

            newForm.Show();
        }

        private void btnShowImageBinary_Click(object sender, EventArgs e)
        {
            var newImage = new Bitmap(_dataParagraph.Binary);
            var newForm = new ShowImage(newImage);

            newForm.Show();
        }

        private void btnShowRealImage_Click(object sender, EventArgs e)
        {
            var newImage = new Bitmap(_dataParagraph.Raw);
            var newForm = new ShowImage(newImage);

            newForm.Show();
        }
    }
}
