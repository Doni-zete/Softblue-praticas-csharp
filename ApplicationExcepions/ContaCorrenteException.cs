using System;
using System.Runtime.Serialization;

namespace ApplicationExcepions
{
    [Serializable]
    internal class ContaCorrenteException : Exception
    {
        public ContaCorrenteException()
        {
        }

        public ContaCorrenteException(string message) : base(message)
        {
        }

        public ContaCorrenteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ContaCorrenteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}