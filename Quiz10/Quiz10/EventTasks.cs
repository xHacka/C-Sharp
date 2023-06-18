using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1. შექმენით მოვლენა, რომელიც აღიძვრება მაშინ, როცა პირველი რიცხვი მეორეზე მეტია. დამამუშავებელს გამოაქვს შესაბამისი შეტყობინება.
 2. შექმენით მოვლენა, რომელიც აღიძვრება მაშინ, როცა ორივე რიცხვი ლუწია. დამამუშავებელს გამოაქვს შესაბამისი შეტყობინება.
 3. შექმენით მოვლენა, რომელიც აღიძვრება მაშინ როცა ორი სტრიქონი ერთნაირი არ არის.
 4. შექმენით მოვლენა, რომელიც აღიძვრება მაშინ, როცა მასივის ყველა ელემენტი 50-ზე ნაკლებია.
 5. შექმნენით მოვლენა, რომელიც აღიძვრება ნულზე გაყოფის შემთხვევაში.
 6. შექმენით მოვლენა, რომელიც აღიძვრება მაშინ როცა 5-ელემენტიან მთელრიცხვა მასივში მხოლოდ ნულებია.
 7. შექმენით მოვლენა, რომელიც აღიძვრება მაშინ როცა 25-სიმბოლოიან სტრიქონში მხოლოდ '*'-ებია.
 8. შექმენით მოვლენა, რომელიც აღიძვრება მაშინ, როცა შეტანილია ლუწი რიცხვი. დამამუშავებელი გასცემს ლუწი რიცხვის კვადრატს.
 */
namespace Quiz10 {
    internal class EventTasks {
        // Event That Is Raised When The First Number Is Greater Than The Second
        public event EventHandler GreaterThan;

        // Event That Fires When Both Numbers Are Even
        public event EventHandler BothNumbersEven;

        // Event That Is Raised When Two Strings Are Not The Same
        public event EventHandler StringsNotEqual;

        // Event That Is Raised When All Elements In The Array Are Less Than 50
        public event EventHandler AllElementsLessThan50;

        // Event That Will Be Raised In Case Of Division By Zero
        public event EventHandler DivisionByZero;

        // Event That Is Raised When A 5-Element Integer Array Contains Only Zeros
        public event EventHandler ArrayContainsOnlyZeros;

        // Event That Fires When There Are Only '*'S In A 25-Character String
        public event EventHandler OnlyStarsInString;

        // Event That Fires When An Even Number Is Entered
        public event EventHandler<int> EvenNumberEntered;

        public void CheckFirstNumberGreaterThanSecond(int a, int b) {
            if (a > b) {
                OnGreaterThan();
            }
        }

        public void CheckBothNumbersEven(int a, int b) {
            if (a % 2 == 0 && b % 2 == 0) {
                OnBothNumbersEven();
            }
        }

        public void CheckStringsNotEqual(string str1, string str2) {
            if (str1 != str2) {
                OnStringsNotEqual();
            }
        }

        public void CheckAllElementsLessThan50(int[] numbers) {
            bool allLessThan50 = true;
            foreach (int num in numbers) {
                if (num >= 50) {
                    allLessThan50 = false;
                    break;
                }
            }

            if (allLessThan50) {
                OnAllElementsLessThan50();
            }
        }

        public void CheckDivisionByZero(int divisor) {
            if (divisor == 0) {
                OnDivisionByZero();
            }
        }

        public void CheckArrayContainsOnlyZeros(int[] array) {
            bool containsOnlyZeros = true;
            foreach (int num in array) {
                if (num != 0) {
                    containsOnlyZeros = false;
                    break;
                }
            }

            if (containsOnlyZeros && array.Length == 5) {
                OnArrayContainsOnlyZeros();
            }
        }

        public void CheckOnlyStarsInString(string str) {
            bool onlyStars = true;
            foreach (char c in str) {
                if (c != '*') {
                    onlyStars = false;
                    break;
                }
            }

            if (onlyStars && str.Length == 25) {
                OnOnlyStarsInString();
            }
        }

        public void CheckEvenNumberEntered(int number) {
            if (number % 2 == 0) {
                OnEvenNumberEntered(number);
            }
        }

        // Invokers
        protected virtual void OnGreaterThan() { GreaterThan?.Invoke(this, EventArgs.Empty); }
        protected virtual void OnBothNumbersEven() { BothNumbersEven?.Invoke(this, EventArgs.Empty); }
        protected virtual void OnStringsNotEqual() { StringsNotEqual?.Invoke(this, EventArgs.Empty); }
        protected virtual void OnAllElementsLessThan50() { AllElementsLessThan50?.Invoke(this, EventArgs.Empty); }
        protected virtual void OnDivisionByZero() { DivisionByZero?.Invoke(this, EventArgs.Empty); }
        protected virtual void OnArrayContainsOnlyZeros() { ArrayContainsOnlyZeros?.Invoke(this, EventArgs.Empty); }
        protected virtual void OnOnlyStarsInString() { OnlyStarsInString?.Invoke(this, EventArgs.Empty); }
        protected virtual void OnEvenNumberEntered(int number) { EvenNumberEntered?.Invoke(this, number); }

        // Handlers
        public void HandleGreaterThan(object sender, EventArgs e) {
            MessageBox.Show("First number is greater than the second number.");
        }

        public void HandleBothNumbersEven(object sender, EventArgs e) {
            MessageBox.Show("Both numbers are even.");
        }

        public void HandleStringsNotEqual(object sender, EventArgs e) {
            MessageBox.Show("The two strings are not equal.");
        }

        public void HandleAllElementsLessThan50(object sender, EventArgs e) {
            MessageBox.Show("All elements in the array are less than 50.");
        }

        public void HandleDivisionByZero(object sender, EventArgs e) {
            MessageBox.Show("Division by zero has occurred.");
        }

        public void HandleArrayContainsOnlyZeros(object sender, EventArgs e) {
            MessageBox.Show("The array contains only zeros.");
        }

        public void HandleOnlyStarsInString(object sender, EventArgs e) {
            MessageBox.Show("The string contains only '*' characters.");
        }

        public void HandleEvenNumberEntered(object sender, int number) {
            int square = number * number;
            MessageBox.Show($"Square of the even number entered: {square}");
        }

        public static EventTasks New() {
            EventTasks events = new EventTasks();

            // Event handlers
            events.GreaterThan            += events.HandleGreaterThan;
            events.BothNumbersEven        += events.HandleBothNumbersEven;
            events.StringsNotEqual        += events.HandleStringsNotEqual;
            events.AllElementsLessThan50  += events.HandleAllElementsLessThan50;
            events.DivisionByZero         += events.HandleDivisionByZero;
            events.ArrayContainsOnlyZeros += events.HandleArrayContainsOnlyZeros;
            events.OnlyStarsInString      += events.HandleOnlyStarsInString;
            events.EvenNumberEntered      += events.HandleEvenNumberEntered;

            return events;
        }
    }
}
