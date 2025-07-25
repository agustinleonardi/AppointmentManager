using System;

namespace AppointmentManager.Domain.Exceptions
{
    public class InvalidEmailException : DomainException
    {
        public InvalidEmailException(string message) : base(message) { }
    }
}
