using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpropagationNeuralNetwork
{
    public class BackpropagationNeuralNetwork
    {
        private int _numInputNeuron;
        private int _numHiddenNeuron;
        private int _numOutputNeuron;

        private Layers _inputs;
        private Layers _hiddenOutputs;
        private Layers _outputs;

        private LayersConnector _inputHiddenWeights;
        private LayersConnector _hiddenOutputWeights;

        private Random _rng;

        private bool _parallelOptimized;

        public BackpropagationNeuralNetwork(int inputNeuron, int hiddenNeuron, int outputNeuron, bool parallelOptimized = false)
        {
            //initialized all variable

            _numInputNeuron = inputNeuron;
            _numHiddenNeuron = hiddenNeuron;
            _numOutputNeuron = outputNeuron;

            _inputs = new Layers(_numInputNeuron, nameof(_inputs));
            _hiddenOutputs = new Layers(_numHiddenNeuron, nameof(_hiddenOutputs));

            _outputs = new Layers(_numOutputNeuron,nameof(_outputs));

            _inputHiddenWeights = new LayersConnector(_inputs, _hiddenOutputs);
            _inputHiddenWeights.connectingLayers(0.0);
            _hiddenOutputWeights = new LayersConnector(_hiddenOutputs, _outputs);
            _hiddenOutputWeights.connectingLayers(0.0);

            _rng = new Random(0);
            this._parallelOptimized = parallelOptimized;
            InitializeWeights();
        }

        private void InitializeWeights()
        {
            int numWeights = (_numInputNeuron * _numHiddenNeuron) +
                (_numHiddenNeuron * _numOutputNeuron) + _numHiddenNeuron + _numOutputNeuron;
            Layers initialWeights = new Layers(numWeights,nameof(initialWeights));
            for (int i = 0; i < initialWeights.NumNeuron; ++i)
                initialWeights.Neurons[i].Value = (0.001 - 0.0001) * _rng.NextDouble() + 0.0001;
            SetWeights(initialWeights);
        }

        //TODO CHECK previllage
        public void SetWeights(Layers weights)
        {
            int numWeights = (_numInputNeuron * _numHiddenNeuron) +
                (_numHiddenNeuron * _numOutputNeuron) + _numHiddenNeuron + _numOutputNeuron;
            if (weights.NumNeuron != numWeights)
                throw new Exception("Bad weights array in SetWeights");

            int k = 0;
            for (int i = 0; i < _numInputNeuron; ++i)
                for (int j = 0; j < _numHiddenNeuron; ++j)
                    _inputHiddenWeights.Connector[i][j] = weights.Neurons[k++].Value;
            for (int i = 0; i < _numHiddenNeuron; ++i)
                _inputHiddenWeights.Biases[i] = weights.Neurons[k++].Value;
            for (int i = 0; i < _numHiddenNeuron; i++)
                for (int j = 0; j < _numOutputNeuron; j++)
                    _hiddenOutputWeights.Connector[i][j] = weights.Neurons[k++].Value;
            for (int i = 0; i < _numOutputNeuron; i++)
                _hiddenOutputWeights.Biases[i] = weights.Neurons[k++].Value;
        }

        //TODO CHECK previllage
        public Layers GetWeights()
        {
            int numWeights = (_numInputNeuron * _numHiddenNeuron) +
                (_numHiddenNeuron * _numOutputNeuron) + _numHiddenNeuron + _numOutputNeuron;
            Layers result = new Layers(numWeights,nameof(result));
            int k = 0;
            for (int i = 0; i < _inputHiddenWeights.Connector.Length; i++)
                for (int j = 0; j < _inputHiddenWeights.Connector[0].Length; j++)
                    result.Neurons[k++].Value = _inputHiddenWeights.Connector[i][j];

            for (int i = 0; i < _inputHiddenWeights.Biases.Length; i++)
                result.Neurons[k++].Value = _inputHiddenWeights.Biases[i];

            for (int i = 0; i < _hiddenOutputWeights.Connector.Length; ++i)
                for (int j = 0; j < _hiddenOutputWeights.Connector[0].Length; ++j)
                    result.Neurons[k++].Value = _hiddenOutputWeights.Connector[i][j];

            for (int i = 0; i < _hiddenOutputWeights.Biases.Length; ++i)
                result.Neurons[k++].Value = _hiddenOutputWeights.Biases[i];

            return result;
        }

        public Layers ComputeOutputs(Layers xValues)
        {
            Layers hSums = new Layers(_numHiddenNeuron, nameof(hSums)); // hidden nodes sums scratch array
            Layers oSums = new Layers(_numOutputNeuron, nameof(oSums)); // output nodes sums

            for (int i = 0; i < xValues.Neurons.Length; ++i) // copy x-values to inputs
                this._inputs.Neurons[i].Value = xValues.Neurons[i].Value;
            // note: no need to copy x-values unless you implement a ToString.
            // more efficient is to simply use the xValues[] directly.

            for (int j = 0; j < _numHiddenNeuron; ++j)  // compute i-h sum of weights * inputs
                for (int i = 0; i < _numInputNeuron; ++i)
                    hSums.Neurons[j].Value += this._inputs.Neurons[i].Value * this._inputHiddenWeights.Connector[i][j]; // note +=

            for (int i = 0; i < _numHiddenNeuron; ++i)  // add biases to hidden sums
                hSums.Neurons[i].Value += this._inputHiddenWeights.Biases[i];

            for (int i = 0; i < _numHiddenNeuron; ++i)   // apply activation
                this._hiddenOutputs.Neurons[i].Value = HyperTan(hSums.Neurons[i].Value); // hard-coded

            for (int j = 0; j < _numOutputNeuron; ++j)   // compute h-o sum of weights * hOutputs
                for (int i = 0; i < _numHiddenNeuron; ++i)
                    oSums.Neurons[j].Value += _hiddenOutputs.Neurons[i].Value * _hiddenOutputWeights.Connector[i][j];

            for (int i = 0; i < _numOutputNeuron; ++i)  // add biases to output sums
                oSums.Neurons[i].Value += _hiddenOutputWeights.Biases[i];

            Layers softOut = Softmax(oSums); // all outputs at once for efficiency

            Array.Copy(softOut.Neurons, _outputs.Neurons, softOut.Neurons.Length);

            Layers retResult = new Layers(_numOutputNeuron, nameof(retResult)); // could define a GetOutputs 

            Array.Copy(this._outputs.Neurons, retResult.Neurons, retResult.Neurons.Length);
            return retResult;
        }

        private Layers Softmax(Layers oSums)
        {
            // does all output nodes at once so scale
            // doesn't have to be re-computed each time
            double sum = 0.0;
            for (int i = 0; i < oSums.Neurons.Length; i++)
                sum += Math.Exp(oSums.Neurons[i].Value);

            Layers result = new Layers(oSums.Neurons.Length,nameof(result));
            for (int i = 0; i < oSums.Neurons.Length; i++)
                result.Neurons[i].Value = Math.Exp(oSums.Neurons[i].Value) / sum;
            return result;
        }

        private double HyperTan(double x)
        {
            if (x < -20.0) return -1.0;
            else if (x > 20.0) return 1.0;
            else return Math.Tanh(x);
        }

        private double Error(Layers[] trainData)
        {
            double sumSquaredError = 0.0;
            Layers xValues = new Layers(_numInputNeuron, nameof(xValues));
            Layers tValues = new Layers(_numOutputNeuron, nameof(tValues));
            for(int i = 0; i < trainData.Length; ++i)
            {
                Array.Copy(trainData[i].Neurons, xValues.Neurons, _numInputNeuron);
                Array.Copy(trainData[i].Neurons, _numInputNeuron, tValues.Neurons, 0, _numOutputNeuron);
                Layers yValues = this.ComputeOutputs(xValues);

                for(int j = 0; j < _numOutputNeuron; ++j)
                {
                    double err = tValues.Neurons[j].Value - yValues.Neurons[j].Value;
                    sumSquaredError += err * err;
                }
            }
            return sumSquaredError / trainData.Length;
        }

        private void Shuffle(int[] sequence)
        {
            for(int i = 0; i < sequence.Length; ++i)
            {
                int r = this._rng.Next(i, sequence.Length);
                int tmp = sequence[r];
                sequence[r] = sequence[i];
                sequence[i] = tmp;
            }
        }

        public Layers Train(double[][] trainData, int maxEpochs, double learnRate, double momentum)
        {
            Layers[] inputLayers = new Layers[trainData.Length];
            for(int i = 0; i < trainData.Length; i++)
            {
                inputLayers[i] = new Layers(trainData[i].Length, nameof(inputLayers)+i);
                for(int j = 0; j < trainData[0].Length; j++)
                {
                    inputLayers[i].Neurons[j].Value = trainData[i][j]; 
                }
            }

            LayersConnector hiddenOutputGradients = new LayersConnector(_hiddenOutputs, _outputs);   // hidden-to-output weight gradients
            hiddenOutputGradients.connectingLayers(0.0);

            LayersConnector inputHiddenGradients = new LayersConnector(_inputs, _hiddenOutputs);           // input-to-hidden weight gradients 
            inputHiddenGradients.connectingLayers(0.0);

            Layers outputSignal = new Layers(_numOutputNeuron,nameof(outputSignal));                            // local gradient output signals - gradients w/o associated input terms
            Layers hiddenSignal = new Layers(_numHiddenNeuron, nameof(hiddenSignal));                           // local gradient hidden node signals

            // back-prop momentum specific arrays 
            LayersConnector inputHiddenPrevWeightDelta = new LayersConnector(_inputs, _hiddenOutputs);
            inputHiddenPrevWeightDelta.connectingLayers(0.0);
            LayersConnector hiddenOutputPrevWeightDelta = new LayersConnector(_hiddenOutputs, _outputs);
            hiddenOutputPrevWeightDelta.connectingLayers(0.0);

            int epoch = 0;
            Layers xValues = new Layers(_numInputNeuron, nameof(xValues));
            Layers tValues = new Layers(_numOutputNeuron, nameof(tValues));
            double derivative = 0.0;
            double errorSignal = 0.0;

            int[] sequence = new int[trainData.Length];
            for (int i = 0; i < sequence.Length; ++i)
                sequence[i] = i;

            int errInterval = maxEpochs / 10;//Interval to check error

            while(epoch < maxEpochs)
            {
                ++epoch;
                if(epoch%errInterval == 0 && epoch < maxEpochs)
                {
                    double trainErr = Error(inputLayers);
                    Console.WriteLine("epoch = " + epoch + " error = " + trainErr.ToString("F4"));
                }
                Shuffle(sequence);// visit each training data in random order
                for (int ii = 0; ii < inputLayers.Length; ++ii)
                {
                    int idx = sequence[ii];
                    Array.Copy(inputLayers[idx].Neurons, xValues.Neurons, _numInputNeuron);
                    Array.Copy(inputLayers[idx].Neurons, _numInputNeuron, tValues.Neurons, 0, _numOutputNeuron);
                    ComputeOutputs(xValues); // copy xValues in, compute outputs 

                    // indices: i = inputs, j = hiddens, k = outputs

                    // 1. compute output node signals (assumes softmax)
                    for (int k = 0; k < _numOutputNeuron; ++k)
                    {
                        errorSignal = tValues.Neurons[k].Value - outputSignal.Neurons[k].Value;
                        derivative = (1 - _outputs.Neurons[k].Value) * _outputs.Neurons[k].Value;
                        outputSignal.Neurons[k].Value = errorSignal * derivative;
                    }

                    if (_parallelOptimized)
                    {
                        // 2. compute hidden-to-output weight gradients using output signals

                        Parallel.For(0, _numHiddenNeuron, j =>
                        {
                            Parallel.For(0, _numOutputNeuron, k =>
                             {
                                 hiddenOutputGradients.Connector[j][k] = outputSignal.Neurons[k].Value * _hiddenOutputs.Neurons[j].Value;
                             });
                        });

                        // 2b. compute output bias gradients using output signals

                        Parallel.For(0, _numOutputNeuron, k =>
                        {
                            hiddenOutputGradients.Biases[k] = outputSignal.Neurons[k].Value * 1.0;// dummy assoc. input value
                        });

                        // 3. compute hidden node signals

                        Parallel.For(0, _numHiddenNeuron, j =>
                        {
                            derivative = (1 + _hiddenOutputs.Neurons[j].Value) * (1 - _hiddenOutputs.Neurons[j].Value); // for tanh
                            double[] sum = new double[_numOutputNeuron];
                            Parallel.For(0, _numOutputNeuron, k =>
                            {
                                sum[k] = outputSignal.Neurons[k].Value * _hiddenOutputWeights.Connector[j][k];
                            });
                            hiddenSignal.Neurons[j].Value = derivative * sum.Sum();
                        });

                        // 4. compute input-hidden weight gradients
                        Parallel.For(0, _numInputNeuron, i =>
                        {
                            Parallel.For(0, _numHiddenNeuron, j =>
                            {
                                inputHiddenGradients.Connector[i][j] = hiddenSignal.Neurons[j].Value * _inputs.Neurons[i].Value;
                            });
                        });

                        // 4b. compute hidden node bias gradients
                        Parallel.For(0, _numHiddenNeuron, j =>
                        {
                            inputHiddenGradients.Biases[j] = hiddenSignal.Neurons[j].Value * 1.0;
                        });

                        // == update weights and biases

                        // update input-to-hidden weights
                        Parallel.For(0, _numInputNeuron, i =>
                        {
                            Parallel.For(0, _numHiddenNeuron, j =>
                            {
                                double delta = inputHiddenGradients.Connector[i][j] * learnRate;
                                _inputHiddenWeights.Connector[i][j] += delta; // would be -= if (o-t)
                                _inputHiddenWeights.Connector[i][j] += inputHiddenPrevWeightDelta.Connector[i][j] * momentum;
                                inputHiddenPrevWeightDelta.Connector[i][j] = delta; // save for next time
                            });
                        });

                        // update hidden biases
                        Parallel.For(0, _numHiddenNeuron, j =>
                        {
                            double delta = inputHiddenGradients.Biases[j] * learnRate;
                            _inputHiddenWeights.Biases[j] += delta;
                            _inputHiddenWeights.Biases[j] += inputHiddenPrevWeightDelta.Biases[j] * momentum;
                            inputHiddenPrevWeightDelta.Biases[j] = delta;
                        });

                        // update hidden-to-output weights
                        Parallel.For(0, _numHiddenNeuron, j =>
                         {
                             Parallel.For(0, _numOutputNeuron, k =>
                             {
                                 double delta = hiddenOutputGradients.Connector[j][k] * learnRate;
                                 _hiddenOutputWeights.Connector[j][k] += delta;
                                 hiddenOutputGradients.Connector[j][k] += hiddenOutputPrevWeightDelta.Connector[j][k] * momentum;
                                 hiddenOutputPrevWeightDelta.Connector[j][k] = delta;
                             });
                         });

                        // update output node biases
                        Parallel.For(0, _numOutputNeuron, k =>
                         {
                             double delta = hiddenOutputGradients.Biases[k] * learnRate;
                             hiddenOutputGradients.Biases[k] += delta;
                             hiddenOutputGradients.Biases[k] += hiddenOutputPrevWeightDelta.Biases[k] * momentum;
                             hiddenOutputPrevWeightDelta.Biases[k] = delta;
                         });
                    }
                    else
                    {
                        // 2. compute hidden-to-output weight gradients using output signals

                        for (int j = 0; j < _numHiddenNeuron; ++j)
                            for (int k = 0; k < _numOutputNeuron; ++k)
                                hiddenOutputGradients.Connector[j][k] = outputSignal.Neurons[k].Value * _hiddenOutputs.Neurons[j].Value;

                        // 2b. compute output bias gradients using output signals
                        for (int k = 0; k < _numOutputNeuron; ++k)
                            hiddenOutputGradients.Biases[k] = outputSignal.Neurons[k].Value * 1.0; // dummy assoc. input value

                        // 3. compute hidden node signals
                        for (int j = 0; j < _numHiddenNeuron; ++j)
                        {
                            derivative = (1 + _hiddenOutputs.Neurons[j].Value) * (1 - _hiddenOutputs.Neurons[j].Value); // for tanh
                            double sum = 0.0; // need sums of output signals times hidden-to-output weights
                            for (int k = 0; k < _numOutputNeuron; ++k)
                            {
                                sum += outputSignal.Neurons[k].Value * _hiddenOutputWeights.Connector[j][k]; // represents error signal
                            }
                            hiddenSignal.Neurons[j].Value = derivative * sum;
                        }

                        // 4. compute input-hidden weight gradients
                        for (int i = 0; i < _numInputNeuron; ++i)
                            for (int j = 0; j < _numHiddenNeuron; ++j)
                                inputHiddenGradients.Connector[i][j] = hiddenSignal.Neurons[j].Value * _inputs.Neurons[i].Value;

                        // 4b. compute hidden node bias gradients
                        for (int j = 0; j < _numHiddenNeuron; ++j)
                            inputHiddenGradients.Biases[j] = hiddenSignal.Neurons[j].Value * 1.0; // dummy 1.0 input

                        // == update weights and biases

                        // update input-to-hidden weights

                        for (int i = 0; i < _numInputNeuron; ++i)
                        {
                            for (int j = 0; j < _numHiddenNeuron; ++j)
                            {
                                double delta = inputHiddenGradients.Connector[i][j] * learnRate;
                                _inputHiddenWeights.Connector[i][j] += delta; // would be -= if (o-t)
                                _inputHiddenWeights.Connector[i][j] += inputHiddenPrevWeightDelta.Connector[i][j] * momentum;
                                inputHiddenPrevWeightDelta.Connector[i][j] = delta; // save for next time
                            }
                        }

                        // update hidden biases
                        for (int j = 0; j < _numHiddenNeuron; ++j)
                        {
                            double delta = inputHiddenGradients.Biases[j] * learnRate;
                            _inputHiddenWeights.Biases[j] += delta;
                            _inputHiddenWeights.Biases[j] += inputHiddenPrevWeightDelta.Biases[j] * momentum;
                            inputHiddenPrevWeightDelta.Biases[j] = delta;
                        }

                        // update hidden-to-output weights
                        for (int j = 0; j < _numHiddenNeuron; ++j)
                        {
                            for (int k = 0; k < _numOutputNeuron; ++k)
                            {
                                double delta = hiddenOutputGradients.Connector[j][k] * learnRate;
                                _hiddenOutputWeights.Connector[j][k] += delta;
                                hiddenOutputGradients.Connector[j][k] += hiddenOutputPrevWeightDelta.Connector[j][k] * momentum;
                                hiddenOutputPrevWeightDelta.Connector[j][k] = delta;
                            }
                        }

                        // update output node biases
                        for (int k = 0; k < _numOutputNeuron; ++k)
                        {
                            double delta = hiddenOutputGradients.Biases[k] * learnRate;
                            hiddenOutputGradients.Biases[k] += delta;
                            hiddenOutputGradients.Biases[k] += hiddenOutputPrevWeightDelta.Biases[k] * momentum;
                            hiddenOutputPrevWeightDelta.Biases[k] = delta;
                        }
                    }

                } // each training item
            } // while
            Layers bestWeights = GetWeights();
            return bestWeights;
        }//Train

        public double Accuracy(double[][] testData)
        {
            Layers[] inputLayers = new Layers[testData.Length];
            for (int i = 0; i < testData.Length; i++)
            {
                inputLayers[i] = new Layers(testData[i].Length, nameof(inputLayers) + i);
                for (int j = 0; j < testData[0].Length; j++)
                {
                    inputLayers[i].Neurons[j].Value = testData[i][j];
                }
            }
            int numCorrect = 0;
            int numWrong = 0;
            Layers xValues = new Layers(_numInputNeuron, nameof(xValues)); // inputs
            Layers tValues = new Layers(_numOutputNeuron, nameof(tValues)); // targets
            Layers yValues;

            for(int i = 0; i < testData.Length; ++i)
            {
                Array.Copy(inputLayers[i].Neurons, xValues.Neurons, _numInputNeuron);
                Array.Copy(inputLayers[i].Neurons, _numInputNeuron, tValues.Neurons, 0, _numOutputNeuron);
                yValues = this.ComputeOutputs(xValues);
                int maxIndex = MaxIndex(yValues);
                int tMaxIndex = MaxIndex(tValues);

                if (maxIndex == tMaxIndex)
                    ++numCorrect;
                else
                    ++numWrong;
            }
            return (numCorrect*1.0)/(numCorrect+numWrong);
        }

        private static int MaxIndex(Layers vector)
        {
            int bigIndex = 0;
            double biggestVal = vector.Neurons[0].Value;
            for(int i = 0; i < vector.NumNeuron; ++i)
            {
                if(vector.Neurons[i].Value > biggestVal)
                {
                    biggestVal = vector.Neurons[i].Value;
                    bigIndex = i;
                }
            }
            return bigIndex;

        }
    }
}
