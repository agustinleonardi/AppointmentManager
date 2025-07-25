using AppointmentManager.Domain.Entities;
using AppointmentManager.Domain.ValueObjects;

namespace AppointmentManager.Domain.Repositories;

public interface IUserRepository
{
    Task AddAsync(User user);
    Task<User?> GetByIdAsync(Guid id);
    Task<User?> GetByEmailAsync(Email email);
    Task<IEnumerable<User>> GetAllAsync();
    Task Update(User user);
    Task Delete(Guid id);
}