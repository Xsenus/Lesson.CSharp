using System;

namespace Lesson__30
{
    class Program
    {
        /*
         * Домашнее задание
         * Сделать проект с небезопасным кодом
         * Поработать с указателями (получить ссылку, передать ссылку, прочитать адрес, прочитать значение)
         * Создать указатель на указатель
         */

        static void Main(string[] args)
        {
            // небезопасный код
            unsafe
            {
                int i = 30;

                int* x, y;

                // даем имя для определенного участка памяти
                int* address = &i;

                Console.WriteLine(*address);
                Console.WriteLine((long)address);

                Console.WriteLine(i);
                *address = 20;

                Console.WriteLine(*address);
                Console.WriteLine(i);

                Console.WriteLine();

                int a = 5;
                int b = 7;

                Console.WriteLine("b = " + *(&a + 1));

                Calc(a, &b);

                Console.WriteLine(a);
                Console.WriteLine(b);

                Console.WriteLine();

                int* adddres2 = address + 4;
                *adddres2 = 777;

                Console.WriteLine(*adddres2);

                int** adr = &address;

                Console.WriteLine("**");
                Console.WriteLine((long)adr);
                Console.WriteLine((long)*adr);
                Console.WriteLine(**adr);
            }

            Console.ReadLine();
        }

        static unsafe void Calc(int i, int* j)
        {
            i = 500;
            *j = 700;
        }

        static void Calc(int i, ref int j)
        {

        }
    }
}
