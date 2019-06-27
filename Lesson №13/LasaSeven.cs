using System;

namespace Lesson__13
{
    class LasaSeven : ICar, IDisposable
    {
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Move(int distance)
        {
            return distance / 40;
        }
    }
}
