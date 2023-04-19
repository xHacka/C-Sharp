using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6 {
    internal class Indexer3 {
        private bool[] array = new bool[5];

        public bool this[int index] {
            get { return array[index]; }  // or // get => array[index];
            set { array[index] = value; } // or // set => array[index] = value;
        }
    }
}
