using System;
using System.Runtime.Serialization;

namespace IskolaProjekt.validation
{
    [Serializable]
    public class ElsoKetBetuNemSzamException : Exception
    {
        public ElsoKetBetuNemSzamException()
        {
        }

        public ElsoKetBetuNemSzamException(string message) : base(message)
        {
        }

        public ElsoKetBetuNemSzamException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ElsoKetBetuNemSzamException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}