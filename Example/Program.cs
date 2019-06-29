using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackpropagationNeuralNetwork;
using FeatureExtraction;
using FeatureExtraction.Moments;
using Preprocessing;
using ProfileProjection;

namespace Example
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "bmp files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    var bitmap = new Bitmap(dlg.FileName);

                    Preprocessing.Preprocessing preprocessing = new Preprocessing.Preprocessing(bitmap, 10, 20);
                    string directoryGrayscale = Path.GetDirectoryName(dlg.FileName) + "\\Grayscale.bmp";
                    preprocessing.GrayscalingImage.Save(directoryGrayscale, ImageFormat.Bmp);

                    string directoryFilteringImage = Path.GetDirectoryName(dlg.FileName) + "\\Filtering.bmp";
                    preprocessing.FilterImage.Save(directoryFilteringImage, ImageFormat.Bmp);

                    string directoryThresholdBinary = Path.GetDirectoryName(dlg.FileName) + "\\AverageBinary.bmp";
                    preprocessing.AverageBinaryImage.Save(directoryThresholdBinary, ImageFormat.Bmp);

                    Console.WriteLine(directoryGrayscale);
                    Console.WriteLine(directoryFilteringImage);
                    Console.WriteLine(directoryThresholdBinary);

                    Console.WriteLine("ProfileProjection");
                    ProfileProjection.ProfileProjection profileProjection = new ProfileProjection.ProfileProjection(preprocessing.Output,10,25);
                    var resultImageHorizontally = profileProjection.ResultImageAfterSliceHorizontally;
                    int i = 0;
                    foreach(Bitmap result in resultImageHorizontally)
                    {
                        string diretorySlicing = Path.GetDirectoryName(dlg.FileName) + "\\slicing-" + i + ".bmp";
                        Console.WriteLine(diretorySlicing);
                        result.Save(diretorySlicing, ImageFormat.Bmp);
                        i++;
                    }
                    //ProfileProjection profileProjection = new ProfileProjection(preprocessing.Output);
                    //var profileProjectionFeature =  profileProjection.ProjectionFeature;

                    /*
                    for(int i = 0; i < profileProjectionFeature.Length; i++)
                    {
                        Console.WriteLine(profileProjectionFeature[i]);
                    }

                    Console.WriteLine("==================================");
                    MomentsHu momentsHu = new MomentsHu(preprocessing.Output);
                    var moments = momentsHu.Moments;
                    Console.WriteLine("Moments");
                    for(int i = 0; i < moments.Length; i++)
                    {
                        Console.WriteLine("Moments " + i + " : " + moments[i]);
                    }
                    */


                    Console.ReadKey();
                }
            }
        }
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("\nBegin neural network back-propagation demo");

            int numInput = 100; // number features
            int numHidden = 500;
            int numOutput = 36; // number of classes for Y
            int numRows = 100;
            int seed = 1; // gives nice demo

            Console.WriteLine("\nGenerating " + numRows +
              " artificial data items with " + numInput + " features");
            double[][] allData = MakeAllData(numInput, numHidden, numOutput,
              numRows, seed);
            Console.WriteLine("Done");

            //ShowMatrix(allData, allData.Length, 2, true);

            Console.WriteLine("\nCreating train (80%) and test (20%) matrices");
            double[][] trainData;
            double[][] testData;
            SplitTrainTest(allData, 0.80, seed, out trainData, out testData);
            Console.WriteLine("Done\n");

            Console.WriteLine("Training data:");
            ShowMatrix(trainData, 4, 2, true);
            Console.WriteLine("Test data:");
            ShowMatrix(testData, 4, 2, true);

            Console.WriteLine("Creating a " + numInput + "-" + numHidden +
              "-" + numOutput + " neural network");
            BackpropagationNeuralNetwork.BackpropagationNeuralNetwork nn = new BackpropagationNeuralNetwork.BackpropagationNeuralNetwork(numInput, numHidden, numOutput, true);

            int maxEpochs = 100;
            double learnRate = 0.05;
            double momentum = 0.01;
            Console.WriteLine("\nSetting maxEpochs = " + maxEpochs);
            Console.WriteLine("Setting learnRate = " + learnRate.ToString("F2"));
            Console.WriteLine("Setting momentum  = " + momentum.ToString("F2"));

            Console.WriteLine("\nStarting training");
            Layers weights = nn.Train(trainData, maxEpochs, learnRate, momentum);
            Console.WriteLine("Done");
            Console.WriteLine("\nFinal neural network model weights and biases:\n");
            ShowVector(weights, 2, 10, true);

            //double[] y = nn.ComputeOutputs(new double[] { 1.0, 2.0, 3.0, 4.0 });
            //ShowVector(y, 3, 3, true);

            double trainAcc = nn.Accuracy(trainData);
            Console.WriteLine("\nFinal accuracy on training data = " +
              trainAcc.ToString("F4"));

            double testAcc = nn.Accuracy(testData);
            Console.WriteLine("Final accuracy on test data     = " +
              testAcc.ToString("F4"));

            Console.WriteLine("\nEnd back-propagation demo\n");
            Console.ReadLine();
        } // Main
        */
        public static void ShowMatrix(double[][] matrix, int numRows,
          int decimals, bool indices)
        {
            int len = matrix.Length.ToString().Length;
            for (int i = 0; i < numRows; ++i)
            {
                if (indices == true)
                    Console.Write("[" + i.ToString().PadLeft(len) + "]  ");
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    double v = matrix[i][j];
                    if (v >= 0.0)
                        Console.Write(" "); // '+'
                    Console.Write(v.ToString("F" + decimals) + "  ");
                }
                Console.WriteLine("");
            }

            if (numRows < matrix.Length)
            {
                Console.WriteLine(". . .");
                int lastRow = matrix.Length - 1;
                if (indices == true)
                    Console.Write("[" + lastRow.ToString().PadLeft(len) + "]  ");
                for (int j = 0; j < matrix[lastRow].Length; ++j)
                {
                    double v = matrix[lastRow][j];
                    if (v >= 0.0)
                        Console.Write(" "); // '+'
                    Console.Write(v.ToString("F" + decimals) + "  ");
                }
            }
            Console.WriteLine("\n");
        }

        public static void ShowVector(Layers vector, int decimals,
          int lineLen, bool newLine)
        {
            for (int i = 0; i < vector.NumNeuron; ++i)
            {
                if (i > 0 && i % lineLen == 0) Console.WriteLine("");
                if (vector.Neurons[i].Value >= 0) Console.Write(" ");
                Console.Write(vector.Neurons[i].Value.ToString("F" + decimals) + " ");
            }
            if (newLine == true)
                Console.WriteLine("");
        }

        static double[][] MakeAllData(int numInput, int numHidden,
          int numOutput, int numRows, int seed)
        {
            Random rnd = new Random(seed);
            int numWeights = (numInput * numHidden) + numHidden +
              (numHidden * numOutput) + numOutput;
            Layers weights = new Layers(numWeights, nameof(weights)); // actually weights & biases
            for (int i = 0; i < numWeights; ++i)
                weights.Neurons[i].Value = 20.0 * rnd.NextDouble() - 10.0; // [-10.0 to 10.0]

            Console.WriteLine("Generating weights and biases:");
            ShowVector(weights, 2, 10, true);

            double[][] result = new double[numRows][]; // allocate return-result
            for (int i = 0; i < numRows; ++i)
                result[i] = new double[numInput + numOutput]; // 1-of-N in last column

            BackpropagationNeuralNetwork.BackpropagationNeuralNetwork gnn =
              new BackpropagationNeuralNetwork.BackpropagationNeuralNetwork(numInput, numHidden, numOutput); // generating NN
            gnn.SetWeights(weights);

            for (int r = 0; r < numRows; ++r) // for each row
            {
                // generate random inputs
                Layers inputs = new Layers(numInput, nameof(inputs));
                for (int i = 0; i < numInput; ++i)
                    inputs.Neurons[i].Value = 20.0 * rnd.NextDouble() - 10.0; // [-10.0 to -10.0]

                // compute outputs
                Layers outputs = gnn.ComputeOutputs(inputs);

                // translate outputs to 1-of-N
                double[] oneOfN = new double[numOutput]; // all 0.0

                int maxIndex = 0;
                double maxValue = outputs.Neurons[0].Value;
                for (int i = 0; i < numOutput; ++i)
                {
                    if (outputs.Neurons[i].Value > maxValue)
                    {
                        maxIndex = i;
                        maxValue = outputs.Neurons[i].Value;
                    }
                }
                oneOfN[maxIndex] = 1.0;

                // place inputs and 1-of-N output values into curr row
                int c = 0; // column into result[][]
                for (int i = 0; i < numInput; ++i) // inputs
                    result[r][c++] = inputs.Neurons[i].Value;
                for (int i = 0; i < numOutput; ++i) // outputs
                    result[r][c++] = oneOfN[i];
            } // each row
            return result;
        } // MakeAllData

        static void SplitTrainTest(double[][] allData, double trainPct,
          int seed, out double[][] trainData, out double[][] testData)
        {
            Random rnd = new Random(seed);
            int totRows = allData.Length;
            int numTrainRows = (int)(totRows * trainPct); // usually 0.80
            int numTestRows = totRows - numTrainRows;
            trainData = new double[numTrainRows][];
            testData = new double[numTestRows][];

            double[][] copy = new double[allData.Length][]; // ref copy of data
            for (int i = 0; i < copy.Length; ++i)
                copy[i] = allData[i];

            for (int i = 0; i < copy.Length; ++i) // scramble order
            {
                int r = rnd.Next(i, copy.Length); // use Fisher-Yates
                double[] tmp = copy[r];
                copy[r] = copy[i];
                copy[i] = tmp;
            }
            for (int i = 0; i < numTrainRows; ++i)
                trainData[i] = copy[i];

            for (int i = 0; i < numTestRows; ++i)
                testData[i] = copy[i + numTrainRows];
        } // SplitTrainTest
    }
}
