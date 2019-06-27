using System;

namespace Lesson__14
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    Console.WriteLine($"Интовый {result}");
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, введите целое число");
                }
            }

            Console.WriteLine(result);

            var i = 2;
            try
            {

                //var i = 5;
                //var j = i / 1;
                //Console.WriteLine(j);

                //int a = 2000000000;
                //int b = 2000000000;
                //int c = checked(a * b);

                //throw new DivideByZeroException("Белиберда");
                //throw new ArgumentNullException("i", "Что-то пошло не так");
                throw new MyOwnException();
            }
            catch (MyOwnException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException) when (i == 5)
            {
                Console.WriteLine("Деление на 0 (i = 5)");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Деление на 0");
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Какое-то исключение");
                //Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Работа завершена");
                Console.ReadLine();
            }

        }
    }
}
