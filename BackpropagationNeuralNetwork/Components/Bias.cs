using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpropagationNeuralNetwork.Components
{
    class Bias
    {
        private double[] _value;
        public Bias(int numBias)
        {
            _value = new double[numBias];
        }
        public double this[int i]
        {
            set
            {
                _value[i] = value;
            }
            get
            {
                return _value[i];
            }
        }
        public double Length
        {
            get
            {
                return _value.Length;
            }
        }
    }
}
