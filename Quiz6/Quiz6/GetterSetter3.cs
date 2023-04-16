using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6 {
    internal class GetterSetter3 {
        private int number;
        public int Number {
            get { return number; }
            set { if (value % 5 == 0) number = value; }
        }
    }
}
