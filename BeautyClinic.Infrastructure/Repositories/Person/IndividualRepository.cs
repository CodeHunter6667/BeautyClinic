using BeautyClinic.Core.Interfaces.Person;
using BeautyClinic.Core.Models.Person;
using BeautyClinic.Infrastructure.Context;
using BeautyClinic.Infrastructure.Repositories;

namespace BeautyClinic.Infrastructure.Repositories.Person;

public class IndividualRepository : Repository<Individual>, IIndividualRepository
{
    public IndividualRepository(AppDbContext context) : base(context)
    {
    }
}
