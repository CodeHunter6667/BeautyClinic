using BeautyClinic.Core.DTOs.Appointment;
using BeautyClinic.Core.Models.Appointment;

namespace BeautyClinic.Core.Extensions;

public static class AppointmentExtension
{
    public static Appointment MapToEntity(this AppointmentDto dto)
    {
        return new Appointment
        {
            Id = dto.Id,
            ClientId = dto.ClientId,
            ProcedureId = dto.ProcedureId,
            ProcedureRoom = dto.ProcedureRoom,
            ProfessionalId = dto.ProfessionalId,
            AppointmentDate = dto.AppointmentDate,
            Status = dto.Status
        };
    }
    
    public static AppointmentDto MapToDto(this Appointment entity)
    {
        return new AppointmentDto
        {
            Id = entity.Id,
            ClientId = entity.ClientId,
            ProcedureId = entity.ProcedureId,
            ProcedureRoom = entity.ProcedureRoom,
            ProfessionalId = entity.ProfessionalId,
            AppointmentDate = entity.AppointmentDate,
            Status = entity.Status
        };
    }
}