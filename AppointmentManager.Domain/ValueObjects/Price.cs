using AppointmentManager.Domain.Exceptions;

namespace AppointmentManager.Domain.ValueObjects;

public class Price
{
    public decimal Value { get; }

    public Price(decimal value)
    {
        if (value < 0)
        {
            throw new InvalidPriceException("El precio no puede ser menor a 0");
        }
        if (value > 25000)
        {
            throw new InvalidPriceException("El precio es demasiado alto");
        }
        Value = value;
    }
}