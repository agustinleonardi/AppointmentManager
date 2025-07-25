using System;

namespace AppointmentManager.Domain.Exceptions
{
    public class UserAlreadyExistsException : DomainException
    {
        public UserAlreadyExistsException(string message) : base(message) { }
    }
}
