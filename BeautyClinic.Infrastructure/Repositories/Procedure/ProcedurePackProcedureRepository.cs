using BeautyClinic.Core.Interfaces.Procedure;
using BeautyClinic.Core.Models.Procedure;
using BeautyClinic.Infrastructure.Context;
using BeautyClinic.Infrastructure.Repositories;

namespace BeautyClinic.Infrastructure.Repositories.Procedure;

public class ProcedurePackProcedureRepository : Repository<ProcedurePackProcedure>, IProcedurePackProcedureRepository
{
    public ProcedurePackProcedureRepository(AppDbContext context) : base(context)
    {
    }
}
