using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6 {
    internal class Indexer1 {
        private int[] array = new int[5];

        public Indexer1(int[] array) {
            this.array = array;
        }
        public Indexer1() : this(AssignRandomNumbers()) {}

        private static int[] AssignRandomNumbers() {
            Random rng = new Random(1001);
            return Enumerable.Range(1, 5).Select(_ => rng.Next()).ToArray();
        }

        public int this[int index] {
            get => array[index];
            set => array[index] = value;
        }
    }
}
