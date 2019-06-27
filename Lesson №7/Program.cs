using System;
using System.Collections.Generic;

namespace Lesson__7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 5;
            int sum = 0;
            int difference = 0;
            int composition = 1;
            int index = 0;

            List<int> number = new List<int>(count);


            while (count != 0)
            {
                if (Int32.TryParse(Console.ReadLine(), out int result))
                {
                    number.Add(result);
                    count--;
                }
            }

            for (int i = 0; i < number.Count; i++)
            {
                sum += number[i];
            }

            while (count < number.Count)
            {
                difference -= number[count];
                count++;
            }

            do
            {
                composition *= number[count - 1];
                count--;
            } while (count > 0);


            Console.WriteLine("Сумма: {0}\nРазность :{1}\nПроизведение: {2}\n", sum, difference, composition);

            foreach (var item in number)
            {
                Console.WriteLine("Элемент коллекции №{0} = {1};", index + 1, item);
                index++;
            }
            Console.ReadLine();
        }
    }
}
