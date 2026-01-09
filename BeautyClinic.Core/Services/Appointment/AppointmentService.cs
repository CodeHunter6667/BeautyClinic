using BeautyClinic.Core.Interfaces;
using BeautyClinic.Core.Interfaces.Appointment;
using BeautyClinic.Core.Services;

namespace BeautyClinic.Core.Services.Appointment;

public class AppointmentService : BaseService<BeautyClinic.Core.Models.Appointment.Appointment>, IAppointmentService
{
    public AppointmentService(IAppointmentRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}
