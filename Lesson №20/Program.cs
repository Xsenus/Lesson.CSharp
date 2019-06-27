using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson__20
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            /*
             * Домашнее задание
             * В вашей предметной области реализовать работу с коллекциями 
             * с помощью LINQ
             * попробовать все операции
             */

            var collection1 = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                collection1.Add(i);
            }

            var result1 = from item in collection1
                         where item < 5
                         select item;

            //var result2 = collection.Where(w => w < 5)
            //                        .Where(w => w % 2 == 0);

            var result2 = collection1.Where(w => w < 5);

            var collection2 = new List<Product>();

            for (int i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Продукт" + (i + 1),
                    Energy = rnd.Next(10, 12)
                };
                collection2.Add(product);
            }

            var result3 = from item in collection2
                          where item.Energy < 200
                          select item;

            var result4 = collection2.Where(x => x.Energy < 200 || x.Energy > 400);

            Console.WriteLine("Result1:");
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nResult2:");
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nResult3:");
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nResult4:");
            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            Console.Clear();

            // На входе коллекция продуктов, на выходе коллекция целых чисел
            var selectCollection = collection2.Select(s => s.Energy);

            var orderbyCollection1 = collection2.OrderBy(o => o.Energy);

            var orderbyCollection2 = collection2.OrderBy(o => o.Energy)
                                                .ThenByDescending(t => t.Name);
            
            Console.WriteLine("selectCollection:");
            foreach (var item in selectCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\norderbyCollection1:");
            foreach (var item in orderbyCollection1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\norderbyCollection2:");
            foreach (var item in orderbyCollection2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            Console.Clear();

            var groupByCollection1 = collection2.GroupBy(g => g.Energy);

            foreach (var group in groupByCollection1)
            {
                Console.WriteLine($"Ключ: {group.Key}");
                //Dictionary<int, List<Product>>
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
                Console.WriteLine();
            }

            // перевернуть список
            collection2.Reverse();

            var all = collection2.All(a => a.Energy == 10);
            var any = collection2.Any(a => a.Energy == 10);

            var newProduct = new Product();
            var contains = collection2.Contains(newProduct);

            Console.WriteLine(all);
            Console.WriteLine(any);
            Console.WriteLine(contains);

            Console.ReadLine();
            Console.Clear();

            var array1 = new int[] { 1, 2, 3, 4 };
            var array2 = new int[] { 3, 4, 5, 6 };

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }

            // Объединение
            var unioin = array1.Union(collection1);
            Console.WriteLine();

            foreach (var item in unioin)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var intersect = array1.Intersect(array2);

            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Вычитание множеств
            var except = array1.Except(array2);

            foreach (var item in except)
            {
                Console.WriteLine(item);
            }

            var sum = array2.Sum();
            var min = collection2.Min(m => m.Energy);
            var max = collection2.Max(m => m.Energy);

            // перемножение чисел
            var aggregate = array1.Aggregate((x, y) => x * y);

            // обработка только части коллекции

            var sum2 = array2.Skip(1).Sum();
            var sum3 = array2.Take(1).Sum();

            var first = array2.FirstOrDefault();
            var last = array2.LastOrDefault();
            
            // получаем Exception если больше 1 элемента == 10
            var single = collection2.Single(s => s.Energy == 10);

            // получение элемента по очереди
            var elementAt = collection1.ElementAt(5);

            Console.ReadLine();
        }
    }
}
