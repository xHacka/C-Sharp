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
    internal class Triangle1Base {
        public int side1;
        private int side2;
        protected int side3;

        public Triangle1Base(int side1, int side2, int side3) {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        protected int getSide2() { return side2; }
    }
}
