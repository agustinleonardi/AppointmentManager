using System;

namespace AppointmentManager.Domain.Exceptions
{
    public class InvalidAppointmentException : DomainException
    {
        public InvalidAppointmentException(string message) : base(message) { }
    }
}
