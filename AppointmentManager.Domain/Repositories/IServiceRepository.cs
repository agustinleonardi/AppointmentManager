using AppointmentManager.Domain.Entities;

namespace AppointmentManager.Domain.Repositories;

public interface IServiceRepository
{
    Task AddAsync(Service service);
    Task<Service?> GetByIdAsync(Guid id);
    Task<IEnumerable<Service>> GetAllAsync();
    Task UpdateAsync(Service service);
    Task DeleteAsync(Guid id);
}