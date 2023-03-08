namespace Quiz1 {
    internal class Square {
        public double Side { get; set; }
        private double area;
        private double perimeter;

        public Square(double side) {
            this.Side = side;
            this.area = side * side;
            this.perimeter = side * 4;
        }

        public double Area {
            get { return area; }
            set { area = value; }
        }

        public string information() {
            return $"Square Details:\n\nSide: {Side}\nPerimeter: {perimeter}\nArea: {area}";
        }
    }
}
