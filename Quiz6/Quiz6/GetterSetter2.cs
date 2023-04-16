using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6 {
    internal class GetterSetter2 {
        private int number;
        public int Number {
            get { return number; }
            set { if (value % 2 != 0) number = value; }
        }
    }
}
