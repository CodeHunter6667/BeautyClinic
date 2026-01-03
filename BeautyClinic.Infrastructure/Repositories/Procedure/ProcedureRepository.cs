using BeautyClinic.Core.Interfaces.Procedure;
using BeautyClinic.Core.Models.Procedure;
using BeautyClinic.Infrastructure.Context;
using BeautyClinic.Infrastructure.Repositories;

namespace BeautyClinic.Infrastructure.Repositories.Procedure;

public class ProcedureRepository : Repository<BeautyClinic.Core.Models.Procedure.Procedure>, IProcedureRepository
{
    public ProcedureRepository(AppDbContext context) : base(context)
    {
    }
}
