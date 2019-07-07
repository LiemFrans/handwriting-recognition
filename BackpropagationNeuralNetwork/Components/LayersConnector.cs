using BackpropagationNeuralNetwork.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpropagationNeuralNetwork
{
    class LayersConnector
    {
        private Layers _l1;
        private Layers _l2;
        private double[][] _connector;
        private Bias _biases;
        public LayersConnector(Layers l1, Layers l2)
        {
            _l1 = l1;
            _l2 = l2;
        }
        public void connectingLayers(double defaultValue)
        {
            Connector = new double[_l1.NumNeuron][];
            for (int r = 0; r < Connector.Length; ++r)
                Connector[r] = new double[_l2.NumNeuron];
            for (int i = 0; i < _l1.NumNeuron; ++i)
                for (int j = 0; j < _l2.NumNeuron; ++j)
                    Connector[i][j] = defaultValue;
            Biases = new Bias(_l2.NumNeuron);
        }

        public double[][] Connector { get => _connector; set => _connector = value; }

        internal Bias Biases { get => _biases; set => _biases = value; }
    }
}
