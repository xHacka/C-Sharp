using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
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
    internal class Doctor : PersonBase {
        public String departmentName;
        public String position;
        public String hospitalName;
        public int yearsWorked;

        public Doctor(String firstName, String lastName, int age, String departmentName, String position, String hospitalName, int yearsWorked) : base(firstName, lastName, age) {
            this.departmentName = departmentName;
            this.position = position;
            this.hospitalName = hospitalName;
            this.yearsWorked = yearsWorked;
        }

        public void DisplayInfo(Label label) {
            label.Text = "Doctor Info:\n\n" +
                        $"Name: {firstName} {lastName}\n" +
                        $"Age: {age}\n" +
                        $"Hostpital Name: {hospitalName}\n" +
                        $"Department Name: {departmentName}\n" +
                        $"Position: {position}\n" +
                        $"Years Worked: {yearsWorked}"
                        ;
        }
    }
}
