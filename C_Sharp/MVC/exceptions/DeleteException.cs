using System;

namespace MVC.exceptions
{
    public class DeleteException : Exception
    {
        public DeleteException(string message) : base(message)
        {
        }
    }
}
