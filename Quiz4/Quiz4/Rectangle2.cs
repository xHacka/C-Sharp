using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 შექმენით საბაზო კლასი, რომელიც შეიცავს დაცულ ცვლადს: მართკუთხედის
ფუძეს; ღია კონსტრუქტორს, რომელიც დაცულ ცვლადს მნიშვნელობას ანიჭებს.
შექმენით მართკუთხედის მემკვიდრე კლასი, რომელიც დამატებით შეიცავს ღია
ცვლადს - მართკუთხედის სიმაღლეს და პრივატულ ცვლადს - მართკუთხედი
ფართობს; ღია მეთოდს, რომელიც გამოთვლის და აბრუნებს მართკუთხედის
ფართობის მნიშვნელობას. მთავარ პროგრამაში შექმენით მემკვიდრე კლასის
ტიპის მქონე ობიექტი და გამოიძახეთ მეთოდი.
 */

namespace Quiz4 {
    internal class Rectangle2 : Rectangle2Base {
        private int height;
        private double area;

        public Rectangle2(int rect_base, int height) : base(rect_base) {
            this.height = height;
            area = GetArea();
        }

        public double GetArea() {
            area = rect_base * height;
            return area;
        }

    }
}