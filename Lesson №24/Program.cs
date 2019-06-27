using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson__24
{
    class Program
    {
        /*
         * Домашнее задание
         * В Вашей предметной области создать анонимный метод и аналогичное лямбда выражение
         * 
         * Использовать делегат, обработчик события и изменять логику метода
         * путем передачи в качестве аргумента делегата
         */

        public delegate int MyHadler(int i);

        static void Main(string[] args)
        {
            Lesson lesson = new Lesson("Программирование");

            lesson.Started += (sender, date) => {
                Console.WriteLine(sender);
                Console.WriteLine(date);
            };

            var list = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            var res = list.Aggregate((x,y) => x + y);
            Console.WriteLine(res);

            var result1 = Agr(list, delegate (int i)
            {
                var r = i * i;
                Console.WriteLine($"Анонимный метод -> {r}");
                return r;
            });

            var result2 = Agr(list, Method);

            var result3 = Agr(list, x => x * x * x * x);

            Console.WriteLine($"result1: {result1}");
            Console.WriteLine($"result2: {result2}");
            Console.WriteLine($"result3: {result3}");

            lesson.Start();

            if (int.TryParse(Console.ReadLine(), out int result))
            {
                // Анонимный метод
                MyHadler handler = delegate (int i)
                {
                    var r = i * i;
                    Console.WriteLine($"Анонимный метод -> {r}");
                    return r;
                };

                handler += Method;

                handler(result);                                
                handler(88);

                //MyHadler lambdaHandler = (i) => i + i;
                //Console.WriteLine($"lambdaHandler = {lambdaHandler(41)}");

                MyHadler lambdaHandler = (i) =>
                {
                    var r = i + i;
                    Console.WriteLine($"lambdaHandler-> {r}");
                    return r;
                };

                lambdaHandler(result);
            }

            Console.ReadLine();
        }

        public static int Agr(List<int> collection, MyHadler myHadler)
        {
            int result = 0;

            foreach (var item in collection)
            {
                result += myHadler(item);
            }

            return result;
        }

        public static int Method(int i)
        {
            var r = i * i * i;
            Console.WriteLine($"Не анонимный метод -> {r}");
            return r;
        }
    }
}
