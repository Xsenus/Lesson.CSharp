using System;
using System.Collections;

namespace Lesson__13
{
    class SuperCar : BMWSeven, IEquatable<int>, IEnumerable
    {
        public bool Equals(int other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
