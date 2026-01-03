using BeautyClinic.Core.Interfaces.Patient;
using BeautyClinic.Core.Models.Patient;
using BeautyClinic.Infrastructure.Context;
using BeautyClinic.Infrastructure.Repositories;

namespace BeautyClinic.Infrastructure.Repositories.Patient;

public class PatientHistoryRepository : Repository<PatientHistory>, IPatientHistoryRepository
{
    public PatientHistoryRepository(AppDbContext context) : base(context)
    {
    }
}
