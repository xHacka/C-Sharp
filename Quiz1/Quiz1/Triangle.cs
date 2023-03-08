namespace Quiz1 {
    internal class Triangle {
        private double perimeter, area;
        public double a, b, c; // Three Sides

        public Triangle(double a, double b, double c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetPerimeter() {
            perimeter = a + b + c;
            return perimeter;
        }

        public double GetArea() {
            // https://www.wikiwand.com/en/Heron%27s_formula
            double s = GetPerimeter() / 2; // Semiperimeter 
            double areaPartial = s * (s - a) * (s - b) * (s - c);
            if (areaPartial <= 0) { return -1; }
            area = System.Math.Sqrt(areaPartial);
            return area;
        }
    }
}
