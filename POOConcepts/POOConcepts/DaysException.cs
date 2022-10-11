using System.Runtime.Serialization;

namespace POOConcepts
{
    [Serializable]
    internal class DaysException : Exception
    {
        public DaysException()
        {
        }

        public DaysException(string? message) : base(message)
        {
        }

        public DaysException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DaysException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}