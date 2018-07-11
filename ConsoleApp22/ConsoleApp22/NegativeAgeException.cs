using System;

namespace ConsoleApp22
{
    class NegativeAgeException : Exception
    {
        public NegativeAgeException()
            : base() { }  //inheriting from the base exception
        public NegativeAgeException(string message)
            : base(message) { }
    }
}
