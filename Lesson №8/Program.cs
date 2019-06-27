using System;

namespace Lesson__8
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;

            //Int32 j = new Int32();

            // Инкапсуляция
            Person person = new Person();

            person.FirstName = "Вадим";
            person.LastName = "Шванов";
            
            // Наследование 
            Person p2 = new Person();

            p2.FirstName = "Иван";
            p2.LastName = "Иванов";

            // Полиморфизм
            var d = new Doctor();
            d.FirstName = "Роман";
            d.Specialization = "123";

            Console.WriteLine(d.FirstName);
            Console.WriteLine(d.Specialization);

            Person p = d;

            Console.WriteLine(p.FirstName);

            Doctor dd = (Doctor)p;

            Console.WriteLine(dd.FirstName);
            Console.WriteLine(dd.Specialization);

            Console.ReadLine();
        }
    }
}
