using System;

namespace Lesson__14
{
    class MyOwnException : Exception
    {
        public MyOwnException() : base("Это мое исключение")
        {
        }
        public MyOwnException(string message) : base(message)
        {
        }


    }
}
