using AppointmentManager.Domain.Exceptions;

namespace AppointmentManager.Domain.ValueObjects;

public class Name
{
    public string Value { get; }

    public Name(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new InvalidNameException("El nombre no puede estar vacio");
        }
        if (name.Length < 2)
        {
            throw new InvalidNameException("El nombre debe tener mas de 2 caracteres");
        }
        if (name.Length > 50)
        {
            throw new InvalidNameException("El nombre no puede tener mas de 50 caracteres");
        }
        Value = name;
    }
}