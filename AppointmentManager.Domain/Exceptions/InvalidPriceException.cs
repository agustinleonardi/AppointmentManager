using System;

namespace AppointmentManager.Domain.Exceptions
{
    public class InvalidPriceException : DomainException
    {
        public InvalidPriceException(string message) : base(message) { }
    }
}
