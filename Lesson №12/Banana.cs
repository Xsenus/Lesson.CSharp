namespace Lesson__12
{
    class Banana<T> : Product<T>
    {
        public Banana(string name, T volume) : base(name, volume)
        {
        }
    }
}
