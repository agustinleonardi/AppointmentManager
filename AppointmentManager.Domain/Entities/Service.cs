using System.Buffers.Binary;
using AppointmentManager.Domain.ValueObjects;

namespace AppointmentManager.Domain.Entities;

public class Service
{
    public Guid Id { get; private set; }
    public Name Name { get; private set; }
    public Duration Duration { get; private set; }
    public Price Price { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private Service() { }

    public Service(Name name, Price price, Duration duration)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        CreatedAt = DateTime.UtcNow;
        Duration = duration;
    }

    public void UpdateName(Name newName)
    {
        if (newName == null)
        {
            throw new ArgumentNullException(nameof(newName));
        }
        Name = newName;
    }

    public void UpdatePrice(Price newPrice)
    {
        if (newPrice == null)
        {
            throw new ArgumentNullException(nameof(newPrice));
        }
        Price = newPrice;
    }

    public void UpdateDuration(Duration newDuration)
    {
        if (newDuration == null)
        {
            throw new ArgumentNullException(nameof(newDuration));
        }
        Duration = newDuration;
    }
}