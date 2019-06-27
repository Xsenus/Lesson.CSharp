using System;
using System.Linq;

namespace Lesson__25
{
    class Program
    {
        /*
         * Домашнее задание
         * Исследовать рефлексию: Реализовать получение свойств, классов, методов
         * Создать свой собственный атрибут
         * Использовать свой собственный атрибут в классе
         */

        static void Main(string[] args)
        {
            var photo = new Photo("hello.png")
            {
                Path = @"C:\hello.png"
            };

            // получаем описание типа (набор данных о классе)
            var type = typeof(Photo);

            var attributes = type.GetCustomAttributes(false);

            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }

            var properties = type.GetProperties();

            foreach (var prop in properties)
            {
                var attrs = prop.GetCustomAttributes(false);

                //var propsWithGeoAttr = attrs.Any(a => a.GetType() == typeof(GeoAttribute));

                if (attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
                {
                    Console.WriteLine(prop.PropertyType + " " + prop.Name);
                }

                //Console.WriteLine(prop.PropertyType + " " + prop.Name);

                //Console.WriteLine(prop.PropertyType + " " + prop.Name + " " + prop.Attributes);

                //foreach (var a in attrs)
                //{
                //    Console.WriteLine($"attrs: {a}");
                //}
            }

            Console.ReadLine();


        }
    }
}
