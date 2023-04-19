using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6 {
    internal class Indexer4 {
        private String[] array = new String[5];

        public String this[int index] {
            get { return array[index]; }  // or // get => array[index];
            set { array[index] = value; } // or // set => array[index] = value;
        }
    }
}
