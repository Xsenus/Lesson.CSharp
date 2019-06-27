using System;

namespace Lesson__12
{
    class Eating<T>
        where T: Product<T>
        //where TT: IEnumerable
    {
        public int Volume { get; private set; }
        public void Add(T product)
        {
            //Volume += product.Volume * product.Energy;
        }
    }

}
