using BeautyClinic.Core.Enums;

namespace BeautyClinic.Core.DTOs.Appointment;

public class AppointmentDto
{
    public long Id { get; set; }
    public DateTime AppointmentDate { get; set; }
    public long ClientId { get; set; }
    public string ProcedureRoom { get; set; } = string.Empty;
    public long ProcedureId { get; set; }
    public long ProfessionalId { get; set; }
    public EAppointmentStatus Status { get; set; }
}
