using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6 {
    internal class Indexer5 {
        private int[] numbers;

        public Indexer5(int[] numbers) { this.numbers = numbers; }

        public int this[int index] { 
            get { return numbers[index]; } 
            set { numbers[index] = value; } 
        }

        public int GetSum() {
            int sum = 0;
            foreach (int number in numbers) { sum += number; }
            return sum;
        }
    }
}
