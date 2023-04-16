using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6 {
    internal class Klasi_2 {
        private static int[,] array2d;

        public Klasi_2(int[,] array) {
            array2d = array;
        }

        private static int CountOddElements() {
            int counter = 0;
            for (int i = 0; i < array2d.GetLength(0); i++) {
                for (int j = 0; j < array2d.GetLength(1); j++) {
                    if (array2d[i, j] % 2 != 0) {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public static int GetNumberOfOddElements() {
            return CountOddElements();
        }
    }
}


