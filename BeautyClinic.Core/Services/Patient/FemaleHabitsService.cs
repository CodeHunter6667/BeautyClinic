using BeautyClinic.Core.Interfaces.Patient;
using BeautyClinic.Core.Models.Patient;
using BeautyClinic.Core.Services;

namespace BeautyClinic.Core.Services.Patient;

public class FemaleHabitsService : BaseService<FemaleHabits>, IFemaleHabitsService
{
    public FemaleHabitsService(IFemaleHabitsRepository repository) : base(repository)
    {
    }
}
