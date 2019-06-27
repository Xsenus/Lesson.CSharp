using System;

namespace Lesson__28
{
    class MyClass : IDisposable
    {
        public MyClass()
        {
        }

        // Деструктор
        ~MyClass()
        {
        }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}
