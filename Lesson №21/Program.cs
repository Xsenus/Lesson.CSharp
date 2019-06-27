using System;
using System.Collections.Generic;

namespace Lesson__21
{
    class Program
    {
        /*
         * Домашнее задание
         * В своей предметной области поработать с методом расширения
         * Создать метод расширения для стандартного типа данных
         * Создать метод расширения для интерфейса
         * *Создать метод расширение для sealed-класса из внешней библиотеки
         */

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                //var isEven = IsEven(result);
                
                //if (isEven)
                if (result.IsEven())
                {
                    Console.WriteLine($"{result} - Четное");
                }
                else
                {
                    Console.WriteLine($"{result} - Нечетное");
                }

                //int h = 77;
                //h.IsEven();

                int h = 182;
                h.IsDividedBy(7);

                var list = new List<Road>();
            }
            else
            {
                Console.WriteLine("Херня какая-то, а не целое число");
            }

            Console.ReadLine();

            var roads = new List<Road>();

            for (int i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);
                roads.Add(road);
            }

            var roadsName = roads.ConvenvertToString();

            //foreach (var road in roads)
            //{
            //    Console.WriteLine(road); ;
            //}
            Console.WriteLine(roadsName);
            Console.ReadLine();
        }

        static bool IsEven(int i)
        {
            return i % 2 == 0;
        }
    }
}
