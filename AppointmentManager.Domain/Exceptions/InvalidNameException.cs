using System;

namespace AppointmentManager.Domain.Exceptions
{
    public class InvalidNameException : DomainException
    {
        public InvalidNameException(string message) : base(message) { }
    }
}
