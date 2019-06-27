using System;
using System.IO;
using System.Text;

namespace Lesson__16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Открыть
            // Прочитать/Записать
            // Закрыть

            //Console.OutputEncoding = Encoding.ASCII;

            using (var sw = new StreamWriter("test.txt", true, Encoding.UTF8))
            {
                sw.WriteLine("Hello world.");
                sw.WriteLine("Hello, User.");
                sw.WriteLine("Привет.");
            }

            using (var sr = new StreamReader("test.txt", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine() + " Конец строки.");
                }

                sr.DiscardBufferedData();
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                var text = sr.ReadToEnd();

                Console.WriteLine(text);
                Console.ReadLine();
            }

            //using (var sw = new StreamWriter("HomeWork.txt", true, Encoding.UTF8))
            //{
            //    sw.Write(Console.);
            //}
        }
    }
}
