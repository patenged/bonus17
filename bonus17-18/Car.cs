using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus17
{
    class Car
    {
        string make;
        string model;
        int year;
        double price;

        public Car() : this("default", "default", 0, 0)
        {

        }

        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public string PrintCar()
        {
            String print = string.Format("{0,10}{1,10}{2,10}{3,10}", make, model, year, price);
            return print;
        }
    }
}
