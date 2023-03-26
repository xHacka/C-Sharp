using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    
    შექმენით საბაზო კლასი, რომელიც შეიცავს დაცულ ცვლადს - მართკუთხედის
ფუძეს. შექმენით მართკუთხედის მემკვიდრე კლასი, რომელიც დამატებით
შეიცავს: პრივატულ ცვლადებს - მართკუთხედის სიმაღლეს და ფართობს; ღია
მეთოდს, რომელიც გამოთვლის და აბრუნებს მართკუთხედის ფართობს. მთავარ
პროგრამაში შექმენით მემკვიდრე კლასის ტიპის მქონე ობიექტი და გამოიძახეთ
მეთოდი.

*/

namespace Quiz4 {
    internal class Rectangle1 : Rectangle1Base {
        private int height;
        private double area;
        public Rectangle1(int rect_base, int height) : base(rect_base) {
            this.height = height;
            area = GetArea();
        }

        public double GetArea() {
            area = rect_base * height;
            return area;
        }

    }
}
