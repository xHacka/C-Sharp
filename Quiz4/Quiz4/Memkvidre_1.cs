using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
         შექმენით ტელევიზორის საბაზო კლასი - Televizori. მასში გამოაცხადეთ დაცული
    ცვლადები: ტელევიზორი 1 საათში რამდენ ვატს მოიხმარს და რამდენი საათის
    განმავლობაშია ჩართული, და კონსტრუქტორი, რომელიც დაცულ წევრებს
    მნიშვნელობებს ანიჭებს. შექმენით Televizori კლასის მემკვიდრე კლასი -
    Memkvidre_1. მასში გამოაცხადეთ პრივატული ცვლადი - ტელევიზორის მიერ
    დახარჯული (მოხმარებული) ვატების რაოდენობა. გამოაცხადეთ
    კონსტრუქტორი, რომელიც იძახებს წინაპარი კლასის კონსტრუქტორს
    მემკვიდრეობითობით მიღებული ცვლადების ინიციალიზების მიზნით. თვით ეს
    კონსტრუქტორი ახდენს ამავე კლასის ცვლადის ინიციალიზებას. ამავე კლასში
    განსაზღვრეთ ღია მეთოდი, რომელსაც ეკრანზე გამოაქვს ყველა ცვლადის
    მნიშვნელობა. მთავარ პროგრამაში შექმენით მემკვიდრე კლასის ტიპის მქონე
    ობიექტი და გამოიძახეთ მეთოდი.
 */

namespace Quiz4 {
    internal class Memkvidre_1 : Televizori {
        private int wattsSpent;

        public Memkvidre_1(int wattsPerHour, int hoursOn) : base(wattsPerHour, hoursOn) {
            wattsSpent = wattsPerHour * hoursOn;
        }

        public void DisplayInfo(Label label) {
            label.Text = "TV Info:\n" +
                        $"Watts Per Hour: {wattsPerHour}\n" +
                        $"Hours On: {hoursOn}\n" +
                        $"Watts Spent: {wattsSpent}";
        }
    }
}
