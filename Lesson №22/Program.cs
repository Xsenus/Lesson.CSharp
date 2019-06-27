using System;
using System.Collections.Generic;

namespace Lesson__22
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car() { Name = "Ford", Number = "A001AA01" },
                new Car() { Name = "Lada", Number = "B727ET77" },
                new Car() { Name = "Mazda", Number = "S007EE54" }
            };

            var parking = new Parking();

            foreach (var car in cars)
            {
                parking.Add(car);
            }

            foreach (var car in parking)
            {
                Console.WriteLine(car);
            }

            foreach (var name in parking.GetNames())
            {
                Console.WriteLine("Name: " + name);
            }

            Console.WriteLine();

            Console.WriteLine(parking["A001AA01"].Name);
            Console.WriteLine(parking["A001AA02"]?.Name);

            Console.WriteLine("Введите номер нового автомобиля");
            var num = Console.ReadLine();

            parking[1] = new Car() { Name = "BMW", Number = num};

            Console.WriteLine(parking[1]);
            Console.ReadLine();
        }
    }
}
