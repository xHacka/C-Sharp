using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
    შექმენით საბაზო კლასი, რომელიც შეიცავს სამკუთხედის გვერდებს. ერთი
 გვერდი არის ღია, მეორე პრივატული და მესამე დაცული. შექმენით სამკუთხედის
 მემკვიდრე კლასი, რომელიც დამატებით შეიცავს პრივატულ ცვლადებს -
 სამკუთხედის პერიმეტრს და ფართობს; ასევე ორ ღია მეთოდს. პირველი მეთოდი
 გამოთვლის და აბრუნებს სამკუთხედის ფართობს. მეორე მეთოდი გამოთვლის და
 გასცემს სამკუთხედის პერიმეტრს. მთავარ პროგრამაში შექმენით მემკვიდრე
 კლასის ტიპის მქონე ობიექტი და გამოიძახეთ ორივე მეთოდი. 

 */

namespace Quiz4 {
    internal class Triangle1 : Triangle1Base {
        private int perimeter;
        private double area;

        public Triangle1(int side1, int side2, int side3) : base(side1, side2, side3) {
            perimeter = GetPerimeter();
            area = GetArea();
        }

        public int GetPerimeter() {
            perimeter = side1 + getSide2() + side3;
            return perimeter;
        }

        public double GetArea() {
            // https://www.wikiwand.com/en/Heron%27s_formula
            double s = GetPerimeter() / 2; // Semiperimeter 
            double areaPartial = s * (s - side1) * (s - getSide2()) * (s - side3);
            if (areaPartial <= 0) { return -1; }
            area = System.Math.Sqrt(areaPartial);
            return area;
        }
    }
}
