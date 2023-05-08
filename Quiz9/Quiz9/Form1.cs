using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz9 {
    public partial class Form1 : Form {
        Random rng = new Random();

        public int[] GenerateRandomArray(int size, int max = 100) {
            return Enumerable.Range(1, size).Select(_ => rng.Next(max)).ToArray();
        }
        const int task2ArraySize = 5;
        int[] task1Array;
        int[,] task2Array = new int[task2ArraySize, task2ArraySize];

        public Form1() {
            InitializeComponent();
            String tab = new string(' ', 10);
            task1Array = GenerateRandomArray(10);
            task1ArrayOutput.Text = $"Array: {String.Join(" ", task1Array)}";
            task2ArrayOutput.Text = $"Matrix: \n{tab}";
            for (int i = 0; i < task2ArraySize; i++) {
                int[] row = GenerateRandomArray(task2ArraySize);
                for (int j = 0; j < task2ArraySize; j++) {
                    String padding = row[j].ToString().Length > 1 ? new string(' ', 3) : new string(' ', 5);
                    task2Array[i, j] = row[j];
                    task2ArrayOutput.Text += $"{row[j]}{padding}";
                }
                task2ArrayOutput.Text += $"\n{tab}";
            }
        }

        private void task1Btn_Click(object sender, EventArgs e) {
            /// ?
            // int sum = 0;
            // for (int i = 0; i < task1Array.Length; i++) {
            //     try { sum += task1Array[i]; } 
            //     catch (IndexOutOfRangeException) { task1Output.Text = "Invalid Index!"; return; }
            // }
            // return sum;
            int index;

            try { index = int.Parse(task1Input.Text.Trim()); } 
            catch (FormatException) { task1Output.Text = "Input Not A Number!"; return; }

            try { task1Output.Text = $"Index {index} = {task1Array[index]}"; } 
            catch (IndexOutOfRangeException) { task1Output.Text = "Invalid Index!"; return; }
        }

        private void task2Btn_Click(object sender, EventArgs e) {
            /// ?
            // int sum = 0;
            // for (int i = 0; i < task2Array.GetLength(0); i++) {
            //     for (int j = 0; j < task2Array.GetLength(1); j++) {
            //         try { sum += task2Array[i, j]; }
            //         catch (IndexOutOfRangeException) { task2Output.Text = "Invalid Indexes!"; return; }
            //     }
            // }
            // return sum;
            int i, j;

            try { i = int.Parse(task2Input_i.Text.Trim()); j = int.Parse(task2Input_j.Text.Trim()); } 
            catch (FormatException) { task2Output.Text = "Invalid Input! (Must Be A Number)"; return; }

            try { task2Output.Text = $"task2Array[{i}, {j}] = {task2Array[i, j]}"; } 
            catch (IndexOutOfRangeException) { task2Output.Text = "Invalid Indexes!"; return; }
        }

        private void task3Btn_Click(object sender, EventArgs e) {
            task3Output.Text = "";
            const int SIZE = 5;
            int[,] array1 = new int[SIZE, SIZE], array2 = new int[SIZE, SIZE];
            for (int i = 0; i < SIZE; i++) { 
                for (int j = 0; j < SIZE; j++) {  
                    array1[i, j] = rng.Next(101); 
                    array2[i, j] = rng.Next(26); 
                }  
            }

            int x = 0, y = 0;
            for (int i = 0; i < array1.GetLength(0); i++) { // Intentionally Creating Bug
                for (int j = 0; j < array1.GetLength(1) + (rng.Next(7) == 4 ? rng.Next(3) : 0); j++) {
                    try {
                        x = array1[i, j]; 
                        y = array2[i, j];
                        if (x == 0 || y == 0) {
                            task3Output.Text += ( x / y).ToString("0.00") + "   ";                    
                        } else {
                            task3Output.Text += ( x / (float) y).ToString("0.00") + "   ";                    
                        }
                    } catch (IndexOutOfRangeException) {
                        task3Output.Text += $"\n --- Error: Index Out Of Range i={i}, j={j} ---\n"; return;
                    } catch (DivideByZeroException) {
                        task3Output.Text += $"\n --- Error: Zero Division x={x} y={y} ---\n"; return;
                    }
                }
                task3Output.Text += "\n";
            }
        }

        private void task4Btn_Click(object sender, EventArgs e) {
            task4Output.Text = "";
            String filename = "task4.txt";
            try { // Write
                using (FileStream file = File.Open(filename, FileMode.Create)) {
                    using (BinaryWriter writer = new BinaryWriter(file)) {
                        foreach (int number in GenerateRandomArray(10)) {
                            writer.Write(number);
                        }
                    }
                }
            } catch (IOException err) {
                task4Output.Text += $"\nError While Trying To Write To File: {err.Message}";
            }

            try { // Read
                using (FileStream file = File.Open(filename, FileMode.Open)) {
                    using (BinaryReader reader = new BinaryReader(file)) {
                        while (reader.PeekChar() != -1) {
                            task4Output.Text += $"{reader.ReadInt32()} ";   
                        }
                    }
                }
            } catch (IOException err) {
                task4Output.Text += $"\nError While Trying To Read File: {err.Message}";
            }

        }

        private void task5Btn_Click(object sender, EventArgs e) {
            task5Output.Text = "";
            String filename = "task5.txt";
            try { // Write
                using (FileStream file = File.Open(filename, FileMode.Create)) {
                    using (StreamWriter writer = new StreamWriter(file)) {
                        for (int i = 0; i < 5; i++) {
                            foreach (int number in GenerateRandomArray(5)) {
                                writer.Write($"{number} ");
                            }
                            writer.Write("\n");
                        }
                    }
                }
            } catch (IOException err) {
                task5Output.Text += $"\nError While Trying To Write To File: {err.Message}";
            }

            try { // Read
                using (FileStream file = File.Open(filename, FileMode.Open)) {
                    using (StreamReader reader = new StreamReader(file)) {
                        while (!reader.EndOfStream) {
                            task5Output.Text += $"{reader.ReadLine()}\n";   
                        }
                    }
                }
            } catch (IOException err) {
                task5Output.Text += $"\nError While Trying To Read File: {err.Message}";
            }

        }
    }
}
