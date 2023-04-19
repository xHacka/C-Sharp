using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6 {
    internal class Indexer2 {
        private double[] array = new double[5];

        public double this[int index] {
            get { return array[index]; }  // or // get => array[index];
            set { array[index] = value; } // or // set => array[index] = value;
        }
    }
}
