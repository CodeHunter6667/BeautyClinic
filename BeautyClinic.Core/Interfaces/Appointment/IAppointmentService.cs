using BeautyClinic.Core.DTOs.Appointment;

namespace BeautyClinic.Core.Interfaces.Appointment;

public interface IAppointmentService : IService<BeautyClinic.Core.Models.Appointment.Appointment>
{
    Task<List<AppointmentDto>> GetByDateRangeAsync(DateTime dataInicial, DateTime dataFinal);
    Task<AppointmentDto> CreateAsync(AppointmentDto dto);
    Task<AppointmentDto> UpdateAppointmentAsync(long id, AppointmentDto dto);
    Task DeleteAppointmentAsync(long id);
    Task<List<AppointmentDto>> GetAllAppointmentsAsync();
    Task<AppointmentDto> GetAppointmentByIdAsync(long id);
}
