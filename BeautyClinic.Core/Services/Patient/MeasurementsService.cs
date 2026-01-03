using BeautyClinic.Core.Interfaces.Patient;
using BeautyClinic.Core.Models.Patient;
using BeautyClinic.Core.Services;

namespace BeautyClinic.Core.Services.Patient;

public class MeasurementsService : BaseService<Measurements>, IMeasurementsService
{
    public MeasurementsService(IMeasurementsRepository repository) : base(repository)
    {
    }
}
