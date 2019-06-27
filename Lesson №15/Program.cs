using System;

namespace Lesson__15
{
    
    class Program
    {
        //public delegate int ValueDelegate(int i);

        //public delegate void MyDelegate();
        //public delegate void Action();

        ////public delegate void MyDelegate(int i);
        ////public delegate void Action(int i);


        //public delegate int Predicate<T>(T value);
        //public delegate int Func(string value);

        //public Action ActionDelegate;

        //public event MyDelegate Event;
        //public event Action EventAction;

        static void Main(string[] args)
        {
            #region Delegate
            //MyDelegate myDelegate1 = Method1;
            //myDelegate1 += Method4;
            //myDelegate1();

            //MyDelegate myDelegate2 = new MyDelegate(Method4);
            //myDelegate2 += Method4;
            //myDelegate2 -= Method4;
            //myDelegate2.Invoke();

            //MyDelegate myDelegate3 = myDelegate1 + myDelegate2;
            //myDelegate3.Invoke();

            //var valueDelegate = new ValueDelegate(MethodValue);
            //valueDelegate += MethodValue;
            //valueDelegate += MethodValue;
            //valueDelegate += MethodValue;
            //valueDelegate += MethodValue;
            //valueDelegate(new Random().Next(10, 50));

            //// Заготовка делегата
            //Action action = Method1;
            //action();

            //Predicate<int> predicate;


            //// Возвращаемое значение делегата в конце
            //Func<int, string> func;

            ////Action<int> action = Method1:
            ////action();

            //Func<int, int> funcc = MethodValue;
            //if (funcc != null)
            //{
            //    funcc(7);
            //}

            //funcc?.Invoke(7);

            #endregion

            Person person = new Person();
            person.Name = "Вася";
            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;

            person.TakeTime(DateTime.Parse("27.12.2018 21:13:01"));
            person.TakeTime(DateTime.Parse("27.12.2018 4:13:01"));


            var sum1 = Sum(5, 5, Calc1);
            var sum2 = Sum(5, 5, Calc2);

            Console.WriteLine($"{sum1} {sum2}");

            Console.ReadLine();
        }

        private static int Sum(int a, int b, Func<int, int, int> calc)
        {
            return calc(a, b);
        }

        private static int Calc1(int i, int j)
        {
            return i + j;
        }
        private static int Calc2(int i, int j)
        {
            return i * j;
        }

        private static void Person_DoWork(object sender, EventArgs e)
        {
            if (sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Name} работает работу");
                //while (true)
                //{

                //}
            }
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("Человек пошел спать.");
        }

        //public static int MethodValue(int i)
        //{
        //    Console.WriteLine(i);
        //    return i;
        //}

        //public static void Method1()
        //{
        //    Console.WriteLine("Method1");
        //}

        //public static int Method2()
        //{
        //    Console.WriteLine("Method2");
        //    return 0;
        //}

        //public static void Method3(int i)
        //{
        //    Console.WriteLine("Method3");
        //}
        //public static void Method4()
        //{
        //    Console.WriteLine("Method4");
        //}
    }
}
