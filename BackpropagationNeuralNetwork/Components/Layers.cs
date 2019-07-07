using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpropagationNeuralNetwork
{
    public class Layers
    {
        private Neuron[] _neurons;
        private string _nameOfLayers;
        private int _numNeuron;
        public Layers(int numNeuron, string nameOfLayers)
        {
            _neurons = new Neuron[numNeuron];
            for(int i = 0; i < numNeuron; i++)
            {
                _neurons[i] = new Neuron();
            }
            _numNeuron = numNeuron;
            _nameOfLayers = nameOfLayers;
        }
        public int NumNeuron
        {
            get
            {
                return this._numNeuron;
            }
        }

        public Neuron[] Neurons { get => _neurons; set => _neurons = value; }
    }
}
