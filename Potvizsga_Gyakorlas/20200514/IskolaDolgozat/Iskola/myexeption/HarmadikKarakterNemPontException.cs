using System;
using System.Runtime.Serialization;

namespace IskolaProjekt.validation
{
    [Serializable]
    public class HarmadikKarakterNemPontException : Exception
    {
        public HarmadikKarakterNemPontException()
        {
        }

        public HarmadikKarakterNemPontException(string message) : base(message)
        {
        }

        public HarmadikKarakterNemPontException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HarmadikKarakterNemPontException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}