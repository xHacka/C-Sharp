using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6 {
    internal class Martkutxedi {
        public static int width, height;
        public int perimeter;

        public Martkutxedi(int width_, int height_) {
            width = width_;
            height = height_;
            perimeter = CalcPerimeter();
        }

        private int CalcPerimeter() { perimeter = (width + height) * 2; return perimeter; }

        public static int GetPerimeter() {
            Martkutxedi martkutxedi = new Martkutxedi(width, height);
            return martkutxedi.perimeter;
        }
    }
}
