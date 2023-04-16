using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz6 {
    public partial class Form1 : Form {
        GetterSetter1 getterSetter1 = new GetterSetter1();
        GetterSetter2 getterSetter2 = new GetterSetter2();
        GetterSetter3 getterSetter3 = new GetterSetter3();
        Indexer1 indexer1;
        int indexer1Index = 0;

        public Form1() {
            InitializeComponent();
        }

        private void static1Btn_Click(object sender, EventArgs e) {
            int width = int.Parse(static1InputWidth.Text.Trim());
            int height = int.Parse(static1InputHeight.Text.Trim());
            Martkutxedi martkutxedi = new Martkutxedi(width, height);
            static1Output.Text = $"Perimeter: {Martkutxedi.GetPerimeter()}";
        }

        private void static2CalcBtn_Click(object sender, EventArgs e) {
            int[] numbers = static2InputNumbers.Text.Trim().Split().Select(Int32.Parse).ToArray();
            Klasi_1 klasi_1 = new Klasi_1(numbers);
            static2Output.Text = $"Sum Of Odd Numbers: {Klasi_1.GetSumOfOddElements()}";
        }

        private void static3CalcBtn_Click(object sender, EventArgs e) {
            const int SIZE_X = 2;
            const int SIZE_Y = 5;
            int[,] array2d = new int[SIZE_X, SIZE_Y];

            static3Output1.Text = "Array 1: ";
            static3Output2.Text = "Array 2: ";

            Random rng = new Random();
            for (int i = 0; i < array2d.GetLength(1); i++) {
                int randNumber = rng.Next(1, 101);
                array2d[0, i] = randNumber;
                static3Output1.Text += $"{randNumber}, ";
            }
            for (int i = 0; i < array2d.GetLength(1); i++) {
                int randNumber = rng.Next(1, 101);
                array2d[1, i] = randNumber;
                static3Output2.Text += $"{randNumber}, ";
            }

            Klasi_2 klasi_2 = new Klasi_2(array2d);
            static3Output3.Text = $"Number Of Odd Elements: {Klasi_2.GetNumberOfOddElements()}";


        }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * */

        private void getterSetters1Btn_Click(object sender, EventArgs e) {
            String numberInput = getterSetters1Input.Text.Trim();
            int number = numberInput != "" ? int.Parse(numberInput) : 0;
            getterSetter1.Number = number;
            getterSetters1Output.Text = $"Updated Number: {getterSetter1.Number}";
        }

        private void getterSetters2Btn_Click(object sender, EventArgs e) {
            String numberInput = getterSetters2Input.Text.Trim();
            int number = numberInput != "" ? int.Parse(numberInput) : 0;
            getterSetter2.Number = number;
            getterSetters2Output.Text = $"Updated Number: {getterSetter2.Number}";
        }

        private void getterSetters3Btn_Click(object sender, EventArgs e) {
            String numberInput = getterSetters3Input.Text.Trim();
            int number = numberInput != "" ? int.Parse(numberInput) : 0;
            getterSetter3.Number = number;
            getterSetters3Output.Text = $"Updated Number: {getterSetter3.Number}";
        }

        private void indexer1Btn_Click(object sender, EventArgs e) {
            indexer1 = new Indexer1(
                indexer1Input.Text.Split() /// Length == 5 !!!
                .Select(Int32.Parse)
                .ToArray()
            );
            // indexer1 = new Indexer1(); /// RNG Version (Without User Input)
        }

        private void indexer1NextBtn_Click(object sender, EventArgs e) {
            if (indexer1Index > 4) { indexer1Index = 0; }
            indexer1Output.Text = $"Index: {indexer1Index}, Value: {indexer1[indexer1Index++]}";
        }
    }
}
