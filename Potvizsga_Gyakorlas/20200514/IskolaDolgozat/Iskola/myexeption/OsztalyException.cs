using System;
using System.Runtime.Serialization;

namespace IskolaProjekt.myexeption
{
    [Serializable]
    internal class OsztalyException : Exception
    {
        public OsztalyException()
        {
        }

        public OsztalyException(string message) : base(message)
        {
        }

        public OsztalyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OsztalyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}