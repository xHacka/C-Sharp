using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Quiz10.DelegateTask3;


/*
 დელეგატს დაუმატეთ 3 მეთოდის მისამართი. სამივე მეთოდი გამოიძახეთ დელეგატის
საშუალებით. შემდეგ, დელეგატს გამოაკელით I და III მეთოდების მისამართები და
დაუმატეთ IV მეთოდის მისამართი. ორივე მეთოდი გამოიძახეთ დელეგატის
საშუალებით. I მეთოდს გადაეცემა ორგანზომილებიანი მთელრიცხვა მასივი. მეთოდი ამ
მასივის კენტ ელემენტებს ამრავლებს 7-ზე. II მეთოდს გადაეცემა ორგანზომილებიანი
მთელრიცხვა მასივი. მეთოდი ამ მასივის ლუწ ელემენტებს ამრავლებს 4-ზე. III მეთოდს
გადაეცემა ორგანზომილებიანი მთელრიცხვა მასივი. მეთოდი ამ მასივის ელემენტებს
ამრავლებს 20-ზე. IV მეთოდს გადაეცემა ორგანზომილებიანი მთელრიცხვა მასივი.
მეთოდი ამ მასივის ელემენტებს ამცირებს 5-ით
 */
namespace Quiz10 {
    internal class DelegateTask4 {
        public delegate void DelegateOfTask4(int[,] array, Label label);

        public static void MethodI(int[,] array, Label label) {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    if (array[i, j] % 2 != 0) {
                        array[i, j] *= 7;
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
                        array[i, j] *= 4;
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
                    array[i, j] *= 20;
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
                    array[i, j] -= 5;
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
            DelegateOfTask4 delegateOfTask4 = MethodI;

            // Add Method II and Method III to the delegate
            delegateOfTask4 += MethodII;
            delegateOfTask4 += MethodIII;

            // Call all three methods via the delegate
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            label.Text += "MethodI && MethodII && MethodIII:\n";
            delegateOfTask4(array, label);

            // Subtract Method I and Method III from the delegate and add Method IV
            delegateOfTask4 -= MethodI;
            delegateOfTask4 -= MethodIII;
            delegateOfTask4 += MethodIV;

            // Call Both Methods Via The Delegate Again
            label.Text += "-----------------------------------------\n";
            label.Text += "MethodII && MethodIV:\n";
            delegateOfTask4(array, label);
        }

    }
}
