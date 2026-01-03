using BeautyClinic.Core.Interfaces.Patient;
using BeautyClinic.Core.Models.Patient;
using BeautyClinic.Core.Services;

namespace BeautyClinic.Core.Services.Patient;

public class HabitsService : BaseService<Habits>, IHabitsService
{
    public HabitsService(IHabitsRepository repository) : base(repository)
    {
    }
}
