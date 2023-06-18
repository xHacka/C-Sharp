using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

/*
 დელეგატს დაუმატეთ 2 მეთოდის მისამართი. ორივე მეთოდი გამოიძახეთ დელეგატის
საშუალებით. შემდეგ, დელეგატს გამოაკელით II მეთოდის მისამართი და დაუმატეთ III
მეთოდის მისამართი. ორივე მეთოდი გამოიძახეთ დელეგატის საშუალებით. I მეთოდს
გადაეცემა ერთგანზომილებიანი მთელრიცხვა მასივი. მეთოდი ამ მასივის კენტ
ელემენტებს ზრდის 5-ჯერ. II მეთოდს გადაეცემა ერთგანზომილებიანი მთელრიცხვა
მასივი. მეთოდი ამ მასივის კენტ ელემენტებს ამცირებს 5-ით. III მეთოდს გადაეცემა
ერთგანზომილებიანი მთელრიცხვა მასივი. მეთოდი ამ მასივის ელემენტებს ამრავლებს
10-ზე. 
 */
namespace Quiz10 {
    internal class DelegateTask2 {
        public delegate void DelegateOfTask2(int[] array, Label label);

        public static void MethodI(int[] array, Label label) {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] % 2 != 0) {
                    array[i] += 5;
                }
            }

            label.Text += "Method I: " + String.Join(", ", array) + "\n";
        }

        public static void MethodII(int[] array, Label label) {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] % 2 != 0) {
                    array[i] -= 5;
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
            DelegateOfTask2 delegateOfTask2 = MethodI;

            // Add Method II To The Delegate
            delegateOfTask2 += MethodII;

            // Call Both Methods Via The Delegate
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            label.Text += "MethodI && MethodII:\n";
            delegateOfTask2(array, label);

            // Subtract Method II From The Delegate And Add Method III
            delegateOfTask2 -= MethodII;
            delegateOfTask2 += MethodIII;

            // Call Both Methods Via The Delegate Again
            label.Text += "-----------------------------------------\n";
            label.Text += "MethodI && MethodIII:\n";
            delegateOfTask2(array, label);
        }
    }
}
