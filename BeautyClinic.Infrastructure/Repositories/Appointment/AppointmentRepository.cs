using BeautyClinic.Core.Interfaces.Appointment;
using BeautyClinic.Infrastructure.Context;
using BeautyClinic.Infrastructure.Repositories;

namespace BeautyClinic.Infrastructure.Repositories.Appointment;

public class AppointmentRepository : Repository<BeautyClinic.Core.Models.Appointment.Appointment>, IAppointmentRepository
{
    public AppointmentRepository(AppDbContext context) : base(context)
    {
    }
}
