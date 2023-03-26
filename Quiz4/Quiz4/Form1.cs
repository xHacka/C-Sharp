using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // protected მოდიფიკატორი, დავალება 2
        private void triangle1CalcBtn_Click(object sender, EventArgs e) {
            int a = int.Parse(triangle1InputSide1.Text.Trim());
            int b = int.Parse(triangle1InputSide2.Text.Trim());
            int c = int.Parse(triangle1InputSide3.Text.Trim());

            Triangle1 triangle = new Triangle1(a, b, c);
            triange1Output.Text = $"Triangle Information:\nPerimter: {triangle.GetPerimeter()}\nArea: {triangle.GetArea()}";
        }

        // protected მოდიფიკატორი, დავალება 2
        private void rect1CalcBtn_Click(object sender, EventArgs e) {
            int height = int.Parse(rect1HeightInput.Text.Trim());
            int rect_base = int.Parse(rect1BaseInput.Text.Trim());

            Rectangle1 rectangle = new Rectangle1(rect_base, height);
            rect1Output.Text = $"Rectangle Information:\nArea: {rectangle.GetArea()}";
        }

        // base საკვანძო სიტყვა, დავალება 1
        private void triangle2CalcBtn_Click(object sender, EventArgs e) {
            int a = int.Parse(triangle2InputSide1.Text.Trim());
            int b = int.Parse(triangle2InputSide2.Text.Trim());
            int c = int.Parse(triangle2InputSide3.Text.Trim());

            Samkutxedi triangle = new Samkutxedi(a, b, c);
            triangle2Output.Text = $"Triangle Information:\nPerimeter: {triangle.GetPerimeter()}";
        }

        // base საკვანძო სიტყვა, დავალება 1
        private void square2CalcBtn_Click(object sender, EventArgs e) {
            int side = int.Parse(square2InputSide.Text.Trim());

            Kvadrati square = new Kvadrati(side);
            square2Output.Text = $"Square Information:\nArea: {square.GetArea()}";
        }

        // base საკვანძო სიტყვა, დავალება 2
        private void tv1CalcBtn_Click(object sender, EventArgs e) {
            int wattsPerHour = int.Parse(tv1InputWattsPerHour.Text.Trim());
            int hoursOn = int.Parse(tv1InputHoursOn.Text.Trim());

            Memkvidre_1 televizori = new Memkvidre_1(wattsPerHour, hoursOn);
            televizori.DisplayInfo(tv1Output);
        }

        // base საკვანძო სიტყვა, დავალება 3
        private void rect2CalcBtn_Click(object sender, EventArgs e) {
            int height = int.Parse(rect2HeightInput.Text.Trim());
            int rect_base = int.Parse(rect2BaseInput.Text.Trim());

            Rectangle2 rectangle = new Rectangle2(rect_base, height);
            rect2Output.Text = $"Rectangle Information:\nArea: {rectangle.GetArea()}";
        }
        
        // base საკვანძო სიტყვა, დავალება 4
        private void doctorInfoBtn_Click(object sender, EventArgs e) {
            String firstname = doctorInputFirstname.Text.Trim();
            String lastname = doctorInputLastname.Text.Trim();
            int age = int.Parse(doctorInputAge.Text.Trim());
            String departmentName = doctorInputDepartment.Text.Trim();
            String position = doctorInputPosition.Text.Trim();
            String hospitalName = doctorInputHospital.Text.Trim();
            int yearsWorked = int.Parse(doctorInputYearsWorked.Text.Trim());

            Doctor doctor = new Doctor(firstname, lastname, age, departmentName, position, hospitalName, yearsWorked);
            doctor.DisplayInfo(doctorOutput);
        }
    }
}
