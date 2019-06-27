using System;

namespace Lesson__28
{
    class Program
    {
        /*
         * Изучить GC
         */
        static void Main(string[] args)
        {
            Console.WriteLine(GC.GetTotalMemory(false));

            for (int i = 0; i < 10000; i++)
            {
                
                var obj = (object)i;

                int j = (int)obj;
            }

            //using (var c = new MyClass())
            //{

            //}

            Console.WriteLine(GC.GetTotalMemory(false));

            GC.Collect();

            Console.WriteLine(GC.GetTotalMemory(false));

            Console.ReadLine();
        }
    }
}
