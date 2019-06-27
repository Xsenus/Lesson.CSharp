using System;

namespace Lesson__12
{
    public class Product<T>
    {
        public string Name { get; set; }
        public T Volume { get; set; }
        public T Energy { get; set; }

        //public Product(string name, T volume, T energy)
        public Product(string name, T volume)
        {
            // TODO: проверить входные параметры

            Name = name;
            Volume = volume;
            Energy = default(T);

        }
    }
}
