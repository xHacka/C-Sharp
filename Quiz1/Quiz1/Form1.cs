using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Quiz1 {
    public partial class Form1 : Form {
        string studentScoresInputHint = "Enter Scores Seperated By Comma";

        public Form1() {
            InitializeComponent();
            panelMain.BringToFront();
        }

        /* TASK 1 START */
        private void classesTask1_Click(object sender, EventArgs e) {
            classesTask1Panel.BringToFront();
            planeDataOutput.Text = string.Empty;
        }

        private void calculatePlaneDataBtn_Click(object sender, EventArgs e) {
            int fuelTankCapacity = 100;
            float distancePerKm = 30.5F;
            string passengersCapacity = passangersCapacityInput.Text.Trim();
            string ticketsSold = ticketsSoldInput.Text.Trim();
            if (passengersCapacity == "" || ticketsSold == "") return; // If Inputs Are Empty Dont Do Anything
            Plane plane = new Plane(fuelTankCapacity, distancePerKm, int.Parse(passengersCapacity), int.Parse(ticketsSold));
            if (plane.TicketsSold > plane.PassenersCapacity) return; // If Tickets Count Is Greater Then Passengers Count Dont Do Anything
            planeDataOutput.Text = plane.information(); // Plane Information
        }
        /* TASK 1 END */
        /* TASK 2 START */
        private void classesTask2_Click(object sender, EventArgs e) {
            classesTask2Panel.BringToFront();
            studentDataOutput.Text = string.Empty;
            studentScoresInput.Text = studentScoresInputHint;
        }

        private void getStudentDetailsBtn_Click(object sender, EventArgs e) {
            string studentFirstName = "Johnny";
            string studentLastName = "Hotbody";
            int age = 59;
            string univercity = univercityInput.Text.Trim();
            string course = courseInput.Text.Trim();
            if (univercity == "" || course == "") return; // If Inputs Are Empty Dont Do Anything
            if (!course.All(char.IsDigit)) return; // If Course Input Is Non Digit Dont Do Anything
            Student student = new Student(studentFirstName, studentLastName, age, univercity, int.Parse(course));
            studentDataOutput.Text = student.information();
        }

        private void studentScoresInput_Enter(object sender, EventArgs e) {
            if (studentScoresInput.Text.Equals(studentScoresInputHint)) {
                studentScoresInput.Text = string.Empty;
                studentScoresInput.Focus();
            }
        }

        private void studentScoresInput_Leave(object sender, EventArgs e) {
            if (studentScoresInput.Text.Equals(string.Empty)) {
                studentScoresInput.Text = studentScoresInputHint;
            }
        }

        private void studentCalcAvgBtn_Click(object sender, EventArgs e) {
            // const int SCORES_COUNT = 10;
            // double[] scores = new double[SCORES_COUNT];
            // string[] scoresStrArray = studentScoresInput.Text.Trim().Split(',').ToArray();
            // if (scoresStrArray.Length != SCORES_COUNT ) {
            //     studentScoresAvgOutput.Text = "Scores length should be 10"; return;
            // }
            // int scoresIndex = 0;
            // for (int i = 0; i < scoresStrArray.Length; i++) {
            //     string str = scoresStrArray[i];
            //     if (str.Equals(string.Empty)) continue; // Ignore Empty Spaces, e.g.: 1,,,32,,2 // Possible Case...
            //     scores[scoresIndex++] = parseDouble(str);
            // }
            double[] scores = studentScoresInput.Text
                                                .Trim()
                                                .Split(',')
                                                .Where(v => !v.Equals(string.Empty))
                                                .Select(v => parseDouble(v))
                                                .ToArray();
            double studentAvgScore = Student.calculateAvgScore(scores);
            studentScoresAvgOutput.Text = $"Average: {studentAvgScore}";
        }

        private void studentAddNewBtn_Click(object sender, EventArgs e) {
            string studentFirstName = studentFirstNameInput.Text.Trim();
            string studentLastName = studentLastNameInput.Text.Trim();
            string studentAgeStr = studentAgeInput.Text.Trim();

            if (studentFirstName.Equals(string.Empty) || studentLastName.Equals(string.Empty) || studentAgeStr.Equals(string.Empty)) return;
            if (!studentAgeStr.All(char.IsDigit)) { studentNewOutput.Text = "Invalid Age!"; return; }

            int studentAge = int.Parse(studentAgeStr);
            if (studentAge < 0 || studentAge > 117) { studentNewOutput.Text = "Invalid Age!"; return; }

            Student student = new Student(studentFirstName, studentLastName, studentAge);
            
            studentNewOutput.Text = student.information();
        }
        /* TASK 2 END */
        /* TASK 3 START*/
        private void classesTask3_Click(object sender, EventArgs e) {
            classesTask3Panel.BringToFront();
            trainDataOutput.Text = string.Empty;
        }

        private void getTrainDetailsBtn_Click(object sender, EventArgs e) {
            int carriges = 10;
            int passengersPerCarriage = 30;
            string ticketPrice = trainTicketPriceInput.Text.Trim();
            string ticketsSold = trainTicketsSoldInput.Text.Trim();
            if (ticketPrice == "" || ticketsSold == "") return; // If Inputs Are Empty Dont Do Anything
            double ticketPriceParsed = parseDouble(ticketPrice);
            Train train = new Train(carriges, passengersPerCarriage, ticketPriceParsed, int.Parse(ticketsSold));
            trainDataOutput.Text = train.information();
        }
        /* TASK 3 END */
        /* TASK 4 START*/
        private void classesTask4_Click(object sender, EventArgs e) {
            classesTask4Panel.BringToFront();
            triangleDataOutput.Text = string.Empty;
        }
        private void triangleCalcBtn_Click(object sender, EventArgs e) {
            try {
                double a = parseDouble(triangleSide1Input.Text.Trim());
                double b = parseDouble(triangleSide2Input.Text.Trim());
                double c = parseDouble(triangleSide3Input.Text.Trim());
                Triangle triangle = new Triangle(a, b, c);
                double area = triangle.GetArea();
                if (area == -1) {
                    string err = "Invalid Triangle!";
                    triangleDataOutput.Text = $"Area: {err}\nPerimeter: {err}";
                } else {
                    triangleDataOutput.Text = $"Area: {area}\nPerimeter: {triangle.GetPerimeter()}";
                }
            } catch (FormatException) {
                triangleDataOutput.Text = "Invalid Input!";
            }

        }
        /* TASK 4 END*/
        /* TASK 5 START */
        private void classesTask5_Click(object sender, EventArgs e) {
            classesTask5Panel.BringToFront();
            carDataOutput.Text = string.Empty;
        }

        private void getCarDetails_Click(object sender, EventArgs e) {
            string color = "Green";
            int doors = 5;
            string ownerLastName = carOwnerLastNameInput.Text.Trim();
            string issuingCompany = carIssuingCompanyInput.Text.Trim();
            Car car = new Car(color, doors, ownerLastName, issuingCompany);
            carDataOutput.Text = car.information();
        }
        /* TASK 5 END */
        /* HELPER METHODS START */
        private double parseDouble(string str) {
            // Float Parsing Depends On Culture???
            // 3.14 -> Fails (Dot)
            // 3,14 -> Ok    (Comma)
            // With This Settings 3.14 Gets Parsed, 3,14 Will Not.
            return double.Parse(str, NumberStyles.Float, CultureInfo.InvariantCulture);
        }

        private void goBackBtn_Click(object sender, EventArgs e) {
            panelMain.BringToFront();
        }
        /* HELPER METHODS END */
        /* TASK 6 START */
        private void classesTask6_Click(object sender, EventArgs e) {
            classesTask6Panel.BringToFront();

        }

        private void squareCalcBtn_Click(object sender, EventArgs e) {
            try {
                Square square = new Square(parseDouble(squareSideInput.Text));
                squareDataOutput.Text = square.information();
            } catch (FormatException) {
                squareDataOutput.Text = "Square Side Invalid Input!";
                return; 
            }
        }
        /* TASK 6 END */
    }
}
