using System;
using System.Collections.Generic;

namespace Lesson__13
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new LasaSeven());
            cars.Add(new BMWSeven());

            foreach (var car in cars)
            {
                Console.WriteLine(car.Move(200));
            }

            Cyborg cyborg = new Cyborg();

            Console.WriteLine(((ICar)cyborg).Move(100));
            Console.WriteLine(((IPerson)cyborg).Move(100));

            Console.ReadLine();
        }
    }
}
