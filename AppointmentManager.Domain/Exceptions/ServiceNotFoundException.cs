using System;

namespace AppointmentManager.Domain.Exceptions
{
    public class ServiceNotFoundException : DomainException
    {
        public ServiceNotFoundException(string message) : base(message) { }
    }
}
