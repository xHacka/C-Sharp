using static Quiz10.DelegateTask1;

namespace Quiz10
{
    public partial class Form1 : Form
    {
        EventTasks events = EventTasks.New();
        public Form1()
        {
            InitializeComponent();
        }

        private void delegateBtnTask1_Click(object sender, EventArgs e)
        {
            DelegateTask1.Execute(delegateOutput);
        }

        private void delegateBtnTask2_Click(object sender, EventArgs e)
        {
            DelegateTask2.Execute(delegateOutput);
        }

        private void delegateBtnTask3_Click(object sender, EventArgs e)
        {
            DelegateTask3.Execute(delegateOutput);
        }

        private void delegateBtnTask4_Click(object sender, EventArgs e)
        {
            DelegateTask4.Execute(delegateOutput);
        }

        private void delegateBtnTask5_Click(object sender, EventArgs e)
        {
            DelegateTask5.Execute(delegateOutput);
        }

        private void delegateClearBtn_Click(object sender, EventArgs e)
        {
            delegateOutput.Text = String.Empty;
        }

        private void eventClearBtn_Click(object sender, EventArgs e)
        {
            eventsOutput.Text = String.Empty;
        }

        private void eventBtnTask1_Click(object sender, EventArgs e)
        {
            int firstNumber = 10;
            int secondNumber = 5;
            events.CheckFirstNumberGreaterThanSecond(firstNumber, secondNumber);
        }

        private void eventBtnTask2_Click(object sender, EventArgs e)
        {
            int number1 = 6;
            int number2 = 8;
            events.CheckBothNumbersEven(number1, number2);
        }

        private void eventBtnTask3_Click(object sender, EventArgs e)
        {
            string str1 = "Hello";
            string str2 = "World";
            events.CheckStringsNotEqual(str1, str2);
        }

        private void eventBtnTask4_Click(object sender, EventArgs e)
        {
            int[] numbers = { 20, 30, 40, 10, 5 };
            events.CheckAllElementsLessThan50(numbers);
        }

        private void eventBtnTask5_Click(object sender, EventArgs e)
        {
            int divisor = 0;
            events.CheckDivisionByZero(divisor);
        }

        private void eventBtnTask6_Click(object sender, EventArgs e)
        {
            int[] array = { 0, 0, 0, 0, 0 };
            events.CheckArrayContainsOnlyZeros(array);
        }

        private void eventBtnTask7_Click(object sender, EventArgs e)
        {
            string starsString = "*************************";
            events.CheckOnlyStarsInString(starsString);
        }

        private void eventBtnTask8_Click(object sender, EventArgs e)
        {
            int evenNumber = 4;
            events.CheckEvenNumberEntered(evenNumber);
        }
    }
}