using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpropagationNeuralNetwork
{
    public class Neuron
    {
        private double _value;

        public Neuron()
        {
            _value = 0.0;
        }
        public double Value
        {
            set
            {
                _value = value;
            }
            get
            {
                return _value;
            }
        }
    }
}
