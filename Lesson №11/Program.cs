using System;

namespace Lesson__11
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple1 = new Apple("Красное яблоко", 100, 100);
            Apple apple2 = new Apple("Зеленое яблоко", 90, 110);

            var sumApple1 = Apple.Add(apple1, apple2);
            var sumApple2 = apple1 + apple2;

            var sumApple3 = apple1 + 100;

            Console.WriteLine(apple1);
            Console.WriteLine(apple2);
            Console.WriteLine(sumApple1);
            Console.WriteLine(sumApple2);
            Console.WriteLine(sumApple3);
            Console.WriteLine(apple1 == apple2);
            Console.WriteLine(apple1 == sumApple3);

            Console.ReadLine();
        }
    }
}
