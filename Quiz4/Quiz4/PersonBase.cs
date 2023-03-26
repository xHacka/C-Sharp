using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

/*
 შექმენით პიროვნების საბაზო კლასი, რომელიც შეიცავს დაცულ ცვლადებს:
გვარს, სახელსა და ასაკს; ღია კონსტრუქტორს, რომელიც დაცულ ცვლადებს
მნიშვნელობებს ანიჭებს. შექმენით ექიმის მემკვიდრე კლასი, რომელიც
დამატებით შეიცავს ღია ცვლადებს: განყოფილების დასახელებას, თანამდებობას,
საავადმყოფოს დასახელებას და სტაჟს. შეიცავს ღია მეთოდებს. პირველი
მეთოდია კონსტრუქტორი, რომელიც საწყის მნიშვნელობებს ანიჭებს ღია
ცვლადებს და იძახებს წინაპარი კლასის კონსტრუქტორს, მემკვიდრეობითობით
მიღებული ცვლადების ინიციალიზების მიზნით. მეორე მეთოდს ეკრანზე
გამოაქვს ყველა ცვლადი. მთავარ პროგრამაში შექმენით მემკვიდრე კლასის ტიპის
მქონე ობიექტი და გამოიძახეთ მეთოდი.
 */

namespace Quiz4 {
    internal class PersonBase {
        protected String firstName;
        protected String lastName;
        protected int age;

        public PersonBase(String fname, String lname, int age) { 
            this.firstName = fname;
            this.lastName = lname;
            this.age = age;
        }
    }
}
