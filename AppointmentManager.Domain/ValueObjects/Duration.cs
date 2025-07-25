using AppointmentManager.Domain.Exceptions;

namespace AppointmentManager.Domain.ValueObjects;

public class Duration
{
    public int Minutes { get; }
    public Duration(int minutes)
    {
        if (minutes <= 0)
        {
            throw new InvalidAppointmentException("Duracion del turno menor a 0 minutos");
        }
        if (minutes > 120)
        {
            throw new InvalidAppointmentException("El turno no puede durar 2 horas");
        }
        Minutes = minutes;
    }
}