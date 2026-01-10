using BeautyClinic.Core.DTOs.Appointment;

namespace BeautyClinic.Core.Interfaces.Appointment;

public interface IAppointmentRepository : IRepository<BeautyClinic.Core.Models.Appointment.Appointment>
{
    Task<List<AppointmentDto>> GetByDateRangeAsync(DateTime dataInicial, DateTime dataFinal);
    Task<List<AppointmentDto>> GetAllAppointmentsAsync();
}
