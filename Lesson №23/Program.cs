using System;

namespace Lesson__23
{
    class Program
    {
        /*
         * Домашнее задание
         * Создать анонимный тип, Tuple и ValueTuple значения.
         * ValueTuple использовать в качестве аргументов метода и 
         * в качестве возвращаемого значения.
         */

        static void Main(string[] args)
        {
            var i = 5;
            int j = 5;

            var product = new { Name = "Milk", Energy = 10 };

            Console.WriteLine(product);
            Console.WriteLine($"\nНаименование: {product.Name} -> Энергетическая ценность: {product.Energy} \n");
            

            var eat = new Eat { Name = "Meat"};

            var product2 = new { eat.Name, Energy = 200};

            Console.WriteLine(product2);

            Console.ReadLine();

            // Кортежи

            // Ссылочный тип - хранятся в куче, доступ чуть помедленнее 
            Tuple<int, string> tuple = new Tuple<int, string>(5, "Привет");
            
            // Значимый тип - хранятся в стеке, доступ быстрее (value tuple)
            var tuple2 = (5, "Привет");
                        
            var tuple3 = (Name: "Tomato", Energy: 20);
            tuple3.Energy = 60;

            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);

            var result = GetData();

            Console.WriteLine($"\n {result.Name} {result.Number} {result.Flag}");

            Console.ReadLine();
        }

        public static (int Number, string Name, bool Flag) GetData()
        {
            var number = 7821; // какой-нибудь метод получения данных
            var name = Guid.NewGuid().ToString(); // какой-нибудь метод получения данных
            bool b = number > 500; // проверка условия


            return ( number, name, b );            
        }
    }
}
