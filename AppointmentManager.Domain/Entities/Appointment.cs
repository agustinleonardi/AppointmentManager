
using AppointmentManager.Domain.ValueObjects;
using System;

namespace AppointmentManager.Domain.Entities
{
    public class Appointment
    {
        public Guid Id { get; private set; }
        public Guid ServiceId { get; private set; }
        public Guid ClientId { get; private set; }
        public DateTime ScheduledAt { get; private set; }
        public Duration Duration { get; private set; }
        public Price Price { get; private set; }
        public DateTime CreatedAt { get; private set; }

        private Appointment() { }

        public Appointment(Service service, Guid clientId, DateTime scheduledAt, Duration duration, Price price)
        {
            Id = Guid.NewGuid();
            ServiceId = service.Id;
            ClientId = clientId;
            ScheduledAt = scheduledAt;
            Duration = service.Duration;
            Price = price;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
