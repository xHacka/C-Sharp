using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6 {
    internal class Klasi_1 {

        private static int[] numbers;

        public Klasi_1(int[] array) {
            numbers = array;
        }

        private int SumOfOddElements() {
            int sum = 0;
            foreach (int number in numbers) { if (number % 2 != 0) { sum += number; } }
            return sum;
        }

        public static int GetSumOfOddElements() {
            Klasi_1 klasi_1 = new Klasi_1(numbers);
            return klasi_1.SumOfOddElements();
        }
    }
}
