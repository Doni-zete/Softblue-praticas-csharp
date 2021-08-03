using System;


namespace InnerExceptions
{

    public class DivisaoException : Exception
    {
        public DivisaoException() { }
        public DivisaoException(string message) : base(message) { }
        public DivisaoException(string message, Exception inner) : base(message, inner) { }
    }
        class Exceptions
        {
        }
    }
