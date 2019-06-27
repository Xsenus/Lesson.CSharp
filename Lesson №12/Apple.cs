using System;
namespace Lesson__12
{
    public class Apple<T> : Product<T>
    {
        public Apple(string name, T volume) : base(name, volume)
        {

        }
    }
}
