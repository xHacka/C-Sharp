using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    
    შექმენით საბაზო კლასი, რომელიც შეიცავს დაცულ ცვლადს - მართკუთხედის
ფუძეს. შექმენით მართკუთხედის მემკვიდრე კლასი, რომელიც დამატებით
შეიცავს: პრივატულ ცვლადებს - მართკუთხედის სიმაღლეს და ფართობს; ღია
მეთოდს, რომელიც გამოთვლის და აბრუნებს მართკუთხედის ფართობს. მთავარ
პროგრამაში შექმენით მემკვიდრე კლასის ტიპის მქონე ობიექტი და გამოიძახეთ
მეთოდი.

*/

namespace Quiz4 {
    internal class Rectangle1Base { 
        protected int rect_base;
            
        protected Rectangle1Base(int rect_base) {
            this.rect_base = rect_base;
        }
    }
}
