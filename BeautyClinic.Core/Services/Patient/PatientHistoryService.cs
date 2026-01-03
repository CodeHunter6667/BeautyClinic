using BeautyClinic.Core.Interfaces.Patient;
using BeautyClinic.Core.Models.Patient;
using BeautyClinic.Core.Services;

namespace BeautyClinic.Core.Services.Patient;

public class PatientHistoryService : BaseService<PatientHistory>, IPatientHistoryService
{
    public PatientHistoryService(IPatientHistoryRepository repository) : base(repository)
    {
    }
}
