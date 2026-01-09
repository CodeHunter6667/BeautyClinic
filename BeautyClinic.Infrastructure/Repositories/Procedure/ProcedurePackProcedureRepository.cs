using BeautyClinic.Core.Interfaces.Procedure;
using BeautyClinic.Core.Models.Procedure;
using BeautyClinic.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BeautyClinic.Infrastructure.Repositories.Procedure;

public class ProcedurePackProcedureRepository : Repository<ProcedurePackProcedure>, IProcedurePackProcedureRepository
{
    public ProcedurePackProcedureRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<ProcedurePackProcedure>> GetByPackIdAsync(long packId)
    {
        return await _dbSet.Where(p => p.ProcedurePackId == packId).ToListAsync();
    }

    public async Task RemoveByPackIdAsync(long packId)
    {
        var items = await _dbSet.Where(p => p.ProcedurePackId == packId).ToListAsync();
        _dbSet.RemoveRange(items);
    }
}
