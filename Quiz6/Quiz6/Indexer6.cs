using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6 {
    internal class Indexer6 {
        private double[,] numbers;

        public Indexer6(double[,] numbers) { this.numbers = numbers; }

        public double this[int row, int col] {
            get { return numbers[row, col]; }
            set { numbers[row, col] = value; }
        }

        public double GetMin() {
            double min = numbers[0, 0];
            for (int i = 0; i < numbers.GetLength(0); i++) {
                for (int j = 0; j < numbers.GetLength(1); j++) {
                    if (min > this[i, j]) min = this[i, j];
                }
            }
            return min;
        }
    }
}