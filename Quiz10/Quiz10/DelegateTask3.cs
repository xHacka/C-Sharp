using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

/*
 დელეგატს დაუმატეთ 3 მეთოდის მისამართი. სამივე მეთოდი გამოიძახეთ დელეგატის
საშუალებით. შემდეგ, დელეგატს გამოაკელით I და III მეთოდების მისამართები და
დაუმატეთ IV მეთოდის მისამართი. ორივე მეთოდი გამოიძახეთ დელეგატის
საშუალებით. I მეთოდს გადაეცემა ორგანზომილებიანი მთელრიცხვა მასივი. მეთოდი ამ
მასივის კენტ ელემენტებს ამრავლებს 3-ზე. II მეთოდს გადაეცემა ორგანზომილებიანი
მთელრიცხვა მასივი. მეთოდი ამ მასივის ლუწ ელემენტებს ამრავლებს 2-ზე. III მეთოდს
გადაეცემა ორგანზომილებიანი მთელრიცხვა მასივი. მეთოდი ამ მასივის ელემენტებს
ამრავლებს 10-ზე. IV მეთოდს გადაეცემა ორგანზომილებიანი მთელრიცხვა მასივი.
მეთოდი ამ მასივის ელემენტებს ზრდის 5-ით
 */

namespace Quiz10 {
    internal class DelegateTask3 {
        public delegate void DelegateOfTask3(int[,] array, Label label);

        public static void MethodI(int[,] array, Label label) {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    if (array[i, j] % 2 != 0) {
                        array[i, j] *= 3;
                    }
                }
            }

            label.Text += "Method I: \n";
            PrintArray(array, label);
        }

        public static void MethodII(int[,] array, Label label) {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    if (array[i, j] % 2 == 0) {
                        array[i, j] *= 2;
                    }
                }
            }

            label.Text += "Method II: \n";
            PrintArray(array, label);
        }

        public static void MethodIII(int[,] array, Label label) {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    array[i, j] *= 10;
                }
            }

            label.Text += "Method III: \n";
            PrintArray(array, label);
        }

        public static void MethodIV(int[,] array, Label label) {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    array[i, j] += 5;
                }
            }

            label.Text += "Method IV: \n";
            PrintArray(array, label);
        }

        public static void PrintArray(int[,] array, Label label) {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    label.Text += array[i, j] + " ";
                }

                label.Text += "\n";
            }

            label.Text += "\n";
        }
        public static void Execute(Label label) {
            // Clear Label Text
            label.Text = String.Empty;

            // Create The Delegate Instance
            DelegateOfTask3 delegateOfTask3 = MethodI;

            // Add Method II And Method III To The Delegate
            delegateOfTask3 += MethodII;
            delegateOfTask3 += MethodIII;

            // Call All Three Methods Via The Delegate
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            label.Text += "MethodI && MethodII && MethodIII:\n";
            delegateOfTask3(array, label);

            // Subtract Method I and Method III From The Delegate And Add Method IV
            delegateOfTask3 -= MethodI;
            delegateOfTask3 -= MethodIII;
            delegateOfTask3 += MethodIV;

            // Call Both Methods Via The Delegate Again
            label.Text += "-----------------------------------------\n";
            label.Text += "MethodII && MethodIV:\n";
            delegateOfTask3(array, label);
        }
    }
}
