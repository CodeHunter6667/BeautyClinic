using BeautyClinic.Core.DTOs.Appointment;
using BeautyClinic.Core.Exceptions;
using BeautyClinic.Core.Extensions;
using BeautyClinic.Core.Interfaces;
using BeautyClinic.Core.Interfaces.Appointment;

namespace BeautyClinic.Core.Services.Appointment;

public class AppointmentService(IAppointmentRepository repository, IUnitOfWork unitOfWork)
    : BaseService<BeautyClinic.Core.Models.Appointment.Appointment>(repository, unitOfWork), IAppointmentService
{
    public Task<List<AppointmentDto>> GetByDateRangeAsync(DateTime dataInicial, DateTime dataFinal)
    {
        return repository.GetByDateRangeAsync(dataInicial, dataFinal);
    }

    public async Task<AppointmentDto> CreateAsync(AppointmentDto dto)
    {
        var appointment = dto.MapToEntity();
        await AddAsync(appointment);
        var result = appointment.MapToDto();
        return result;
    }

    public async Task<AppointmentDto> UpdateAppointmentAsync(long id, AppointmentDto dto)
    {
        var existingAppointment = await GetByIdAsync(id);
        if (existingAppointment == null)
            throw new ResourceNotFoundException("Agendamento não encontrado.");

        existingAppointment = dto.MapToEntity();
        await UpdateAsync(existingAppointment);
        var result = existingAppointment.MapToDto();
        return result;
    }

    public async Task DeleteAppointmentAsync(long id)
    {
        var existingAppointment = GetByIdAsync(id).Result;
        if (existingAppointment == null)
            throw new ResourceNotFoundException("Agendamento não encontrado.");

        await RemoveAsync(id);
    }

    public async Task<List<AppointmentDto>> GetAllAppointmentsAsync()
    {
        var appointments = await repository.GetAllAppointmentsAsync();
        return appointments;
    }

    public async Task<AppointmentDto> GetAppointmentByIdAsync(long id)
    {
        return await repository.GetByIdAsync(id).ContinueWith(task =>
        {
            var appointment = task.Result;
            return appointment?.MapToDto();
        }) ?? throw new ResourceNotFoundException("Agendamento não encontrado.");
    }
}
