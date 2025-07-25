using AppointmentManager.Domain.Entities;

namespace AppointmentManager.Domain.Repositories;

public interface IAppointmentRepository
{
    Task AddAsync(Appointment appointment);
    Task<Appointment?> GetByIdAsync(Guid id);
    Task<IEnumerable<Appointment>> GetAllAsync();
    Task<IEnumerable<Appointment>> GetByClientIdAsync(Guid clientId);
    Task UpdateAsync(Appointment appointment);
    Task DeleteAsync(Guid id);
}