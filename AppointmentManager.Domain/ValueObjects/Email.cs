using System.Text.RegularExpressions;
using AppointmentManager.Domain.Exceptions;

namespace AppointmentManager.Domain.ValueObjects;

public class Email
{
    public string Value { get; }

    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidEmailException("El email no puede estar vacio");
        }
        if (!Regex.IsMatch(value, @"^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$"))
        {
            throw new InvalidEmailException("El formato del email es invalido");
        }
        Value = value.Trim().ToLower();
    }

}