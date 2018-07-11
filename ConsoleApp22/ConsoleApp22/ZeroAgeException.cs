using System;

namespace ConsoleApp22
{
    class ZeroAgeException : Exception
    {
        public ZeroAgeException()
            : base() { }  //inheriting from the base exception
        public ZeroAgeException(string message)
            : base(message) { }
    }
}
