using System;

namespace ConnnectToSql2
{
    internal class CustomException : Exception
    {
        public CustomException() { }

        public CustomException(string message) : base(message) { }
    }
}
