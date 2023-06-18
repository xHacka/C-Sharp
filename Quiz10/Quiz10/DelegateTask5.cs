using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

/*
 დელეგატს დაუმატეთ 3 მეთოდის მისამართი. სამივე მეთოდი გამოიძახეთ დელეგატის
საშუალებით. შემდეგ, დელეგატს გამოაკელით II და III მეთოდების მისამართები და
დაუმატეთ IV მეთოდის მისამართი. ორივე მეთოდი გამოიძახეთ დელეგატის
საშუალებით. I მეთოდს გადაეცემა სტრიქონი. მეთოდი ამ სტრიქონში ხმოვან
სიმბოლოებს შეცვლის სიმბოლო-ციფრით ‘0’. II მეთოდს გადაეცემა სტრიქონი. მეთოდი
ამ სტრიქონში ‘ბ’ სიმბოლოს შეცვლის სიმბოლო-ციფრით ‘1’. III მეთოდს გადაეცემა
სტრიქონი. მეთოდი ამ სტრიქონში წაშლის ‘ა’ სიმბოლოს. IV მეთოდს გადაეცემა
სტრიქონი. მეთოდი ამ სტრიქონში წაშლის სასვენ ნიშნებს.
 */
namespace Quiz10 {
    internal class DelegateTask5 {
        public delegate void DelegateOfTask5(String str, Label label);

        public static void MethodI(String str, Label label) {
            String vowels = "aeiou";
            String result = Regex.Replace(str, $"[{vowels}]", "0", RegexOptions.IgnoreCase);

            label.Text += $"Method I: {result} \n";
        }

        public static void MethodII(String str, Label label) {
            String result = str.Replace("b", "1");

            label.Text += $"Method II: {result} \n";
        }

        public static void MethodIII(String str, Label label) {
            String result = str.Replace("a", String.Empty);

            label.Text += $"Method III: {result} \n";
        }

        public static void MethodIV(String str, Label label) {
            String result = Regex.Replace(str, @"\p{P}", String.Empty);

            label.Text += $"Method IV: {result} \n";
        }

        public static void Execute(Label label) {
            // Clear Label Text
            label.Text = String.Empty;

            // Create The Delegate Instance
            DelegateOfTask5 delegateOfTask5 = MethodI;

            // Add Method II And Method III To The Delegate
            delegateOfTask5 += MethodII;
            delegateOfTask5 += MethodIII;

            // Call all three methods via the delegate
            String str = "Hello, this is a sample String!";
            label.Text += "MethodI && MethodII && MethodIII:\n";
            delegateOfTask5(str, label);

            // Subtract Method II And Method III From The Delegate And Add Method IV
            delegateOfTask5 -= MethodII;
            delegateOfTask5 -= MethodIII;
            delegateOfTask5 += MethodIV;

            // Call both methods via the delegate again
            label.Text += "-----------------------------------------\n";
            label.Text += "MethodI && MethodIV:\n";
            delegateOfTask5(str, label);
        }
    }
}
