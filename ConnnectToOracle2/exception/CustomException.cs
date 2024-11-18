using System;

namespace ConnnectToOracle2
{
    internal class CustomException : Exception
    {
        public CustomException() { }

        public CustomException(string message) : base(message) { }
    }
}
