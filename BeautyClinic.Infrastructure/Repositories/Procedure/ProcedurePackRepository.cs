using BeautyClinic.Core.Interfaces.Procedure;
using BeautyClinic.Core.Models.Procedure;
using BeautyClinic.Infrastructure.Context;
using BeautyClinic.Infrastructure.Repositories;

namespace BeautyClinic.Infrastructure.Repositories.Procedure;

public class ProcedurePackRepository : Repository<ProcedurePack>, IProcedurePackRepository
{
    public ProcedurePackRepository(AppDbContext context) : base(context)
    {
    }
}
