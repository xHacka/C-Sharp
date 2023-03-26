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
    internal class Rectangle2Base {
        protected int rect_base;

        public Rectangle2Base(int rect_base) { 
            this.rect_base = rect_base;
        }
    }
}
