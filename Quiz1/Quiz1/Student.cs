using System.Linq;

namespace Quiz1 {
    internal class Student {
        private readonly string fName, lName;
        private readonly int age;
        public string university;
        public int course;

        public Student(string fName, string lName, int age) {
            this.fName = fName;
            this.lName = lName;
            this.age = age;
        }

        public Student(string fName, string lName, int age, string university, int course) {
            this.fName = fName;
            this.lName = lName;
            this.age = age;
            this.university = university;
            this.course = course;
        }

        public static double calculateAvgScore(double[] scores) {
            /// Simple Approach
            // double sum = 0;
            // int arrLen = scores.Length;
            // for (int i = 0; i < arrLen; i++) { sum += scores[i]; }
            // double avg = sum / arrLen;

            /// LinQ
            // double avg = scores.Sum() / scores.Length;
            double avg = scores.Average();
            return avg;
        }

        public string information() {
            string info = $"Student Data \n\nStudent: {fName} {lName}, {age}";
            if (university != null) {
                info += $"\nUniversity: {university}";
            }
            if (course > 0) {
                info += $"\nCourse: {course}";
            }
            return info;
        }
    }
}
