using System.ComponentModel.DataAnnotations;
using AppointmentManager.Domain.Enums;
using AppointmentManager.Domain.Exceptions;
using AppointmentManager.Domain.ValueObjects;

namespace AppointmentManager.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public Name Name { get; private set; }
    public Email Email { get; private set; }
    public string PasswordHash { get; private set; }
    public Role Role { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private User() { }

    public User(Name name, Email email, string passwordHash, Role role)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
        IsActive = true;
        CreatedAt = DateTime.UtcNow;
    }
    public void UpdateName(Name name)
    {
        if (name == null)
        {
            throw new InvalidNameException("El nombre esta vacio");
        }
        Name = name;
    }
}