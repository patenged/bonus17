using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus17
{
    class CarApp
    {
        string make;
        string model;
        int year;
        double price;

        public void MakeCars()
        {
            string input;
            int x;

            Console.WriteLine("How many cars would you like to input?");
            input = Console.ReadLine();

            List<Car> Cars = new List<Car>();

            if (int.TryParse(input, out x))
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write("What's the make of the car" + (i + 1) + " : ");
                    make = Console.ReadLine();
                    Console.Write("What's the model of the car" + (i + 1) + " : ");
                    model = Console.ReadLine();
                    Console.Write("What's the year of the car" + (i + 1) + " : ");
                    int.TryParse(Console.ReadLine(), out year);
                    Console.Write("What's the price of the car" + (i + 1) + " : ");
                    double.TryParse(Console.ReadLine(), out price);
                    Car c = new Car(make, model, year, price);
                    Cars.Add(c);
                }
                Console.WriteLine();
                foreach (Car c in Cars)
                {
                    Console.WriteLine(c.PrintCar());
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
                MakeCars();
            }
        }
    }
}
