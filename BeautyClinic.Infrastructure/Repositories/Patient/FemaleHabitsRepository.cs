using BeautyClinic.Core.Interfaces.Patient;
using BeautyClinic.Core.Models.Patient;
using BeautyClinic.Infrastructure.Context;
using BeautyClinic.Infrastructure.Repositories;

namespace BeautyClinic.Infrastructure.Repositories.Patient;

public class FemaleHabitsRepository : Repository<FemaleHabits>, IFemaleHabitsRepository
{
    public FemaleHabitsRepository(AppDbContext context) : base(context)
    {
    }
}
