using System;
using System.Runtime.Serialization;

namespace IskolaProjekt.validation
{
    [Serializable]
    public class NegyedikKarakerNemKisBetuException : Exception
    {
        public NegyedikKarakerNemKisBetuException()
        {
        }

        public NegyedikKarakerNemKisBetuException(string message) : base(message)
        {
        }

        public NegyedikKarakerNemKisBetuException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegyedikKarakerNemKisBetuException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}