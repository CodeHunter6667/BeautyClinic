using BeautyClinic.Core.Interfaces.Person;
using BeautyClinic.Core.Models.Person;
using BeautyClinic.Infrastructure.Context;
using BeautyClinic.Infrastructure.Repositories;

namespace BeautyClinic.Infrastructure.Repositories.Person;

public class ProfessionalRepository : Repository<Professional>, IProfessionalRepository
{
    public ProfessionalRepository(AppDbContext context) : base(context)
    {
    }
}
