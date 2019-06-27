using System;

namespace Lesson__10
{
    class Program
    {
        static void Main(string[] args)
        {
            //var i = PrintHello("Илья", 26);

            var person1 = new Person("Иванов", "Иван");
            var person2 = new Person("Мамка", "Админа");

            for (int i = 0; i < 10; i++)
            {
                var position1 = person1.Run();
                Console.WriteLine(position1);

                var position2 = person2.Run();
                Console.WriteLine(position2);
            }

            Console.WriteLine($" \n{Factorial(5)}\n");

            Console.WriteLine($" \n{Fib(10)}");
            //Console.WriteLine(i);
            Console.ReadLine();
        }

        public static int PrintHello(string name, int age)
        {
            Console.WriteLine($"Привет, {name}. Вам {age} лет");

            return 1;
        } 

        public static int Factorial(int value)
        {
            if (value <= 1)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }
        
        public static int Fib(int value)
        {
            if (value == 0)
            {
                return 0;
            }
            if (value == 1)
            {
                return 1;
            }
            else
            {
                return Fib(value - 1) + Fib(value - 2);
            }
        }
    }
}
