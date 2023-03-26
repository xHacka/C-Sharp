using System;
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
    internal class Televizori {
        protected int wattsPerHour;
        protected int hoursOn;

        public Televizori(int wattsPerHour, int hoursOn) {
            this.wattsPerHour = wattsPerHour;
            this.hoursOn = hoursOn;
        }
    }
}
