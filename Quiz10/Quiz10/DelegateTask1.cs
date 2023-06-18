using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 დელეგატს დაუმატეთ 2 მეთოდის მისამართი. ორივე მეთოდი გამოიძახეთ დელეგატის
საშუალებით. შემდეგ, დელეგატს გამოაკელით I მეთოდის მისამართი და დაუმატეთ III
მეთოდის მისამართი. ორივე მეთოდი გამოიძახეთ დელეგატის საშუალებით. I მეთოდს
გადაეცემა ერთგანზომილებიანი მთელრიცხვა მასივი. მეთოდი ამ მასივის კენტ
ელემენტებს ამრავლებს 3-ზე. II მეთოდს გადაეცემა ერთგანზომილებიანი მთელრიცხვა
მასივი. მეთოდი ამ მასივის ლუწ ელემენტებს ამრავლებს 2-ზე. III მეთოდს გადაეცემა
ერთგანზომილებიანი მთელრიცხვა მასივი. მეთოდი ამ მასივის ელემენტებს ამრავლებს
10-ზე.
 */
namespace Quiz10 {
    internal class DelegateTask1 {
        public delegate void DelegateOfTask1(int[] array, Label label);

        public static void MethodI(int[] array, Label label) {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] % 2 != 0) {
                    array[i] *= 3;
                }
            }

            label.Text += "Method I: " + String.Join(", ", array) + "\n";
        }

        public static void MethodII(int[] array, Label label) {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] % 2 == 0) {
                    array[i] *= 2;
                }
            }

            label.Text += "Method II: " + String.Join(", ", array) + "\n";
        }

        public static void MethodIII(int[] array, Label label) {
            for (int i = 0; i < array.Length; i++) {
                array[i] *= 10;
            }

            label.Text += "Method III: " + String.Join(", ", array) + "\n";
        }

        public static void Execute(Label label) {
            // Clear Label Text
            label.Text = String.Empty;

            // Create The Delegate Instance
            DelegateOfTask1 delegateOfTask1 = MethodI;

            // Add Method II To The Delegate
            delegateOfTask1 += MethodII;

            // Call Both Methods Via The Delegate
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            label.Text += "MethodI && MethodII:\n";
            delegateOfTask1(array, label);

            // Subtract Method I From The Delegate And Add Method III
            delegateOfTask1 -= MethodI;
            delegateOfTask1 += MethodIII;

            // Call Both Methods Via The Delegate Again
            label.Text += "-----------------------------------------\n";
            label.Text += "MethodII && MethodIII:\n";
            delegateOfTask1(array, label);
        }
    }
}
