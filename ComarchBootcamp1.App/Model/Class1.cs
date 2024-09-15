using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchBootcamp1.App.Model {
    /// <summary>
    /// Moja fajna klasa 1
    /// </summary>
    public class Auto {
        protected string marka = "Audi";
    }

    public class Car : Auto {
        public Car() {
            marka = "BMW";
        }
    }

    public class Truck : Car {
        public Truck() {
            marka = "Volvo";
        }
    }

    public class Bus : Auto {
        public Bus() { }
    }
}
