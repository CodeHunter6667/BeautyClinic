using BeautyClinic.Core.Interfaces;
using BeautyClinic.Core.Models.Procedure;

namespace BeautyClinic.Core.Interfaces.Procedure;

public interface IProcedurePackProcedureRepository : IRepository<ProcedurePackProcedure>
{
    Task<IEnumerable<ProcedurePackProcedure>> GetByPackIdAsync(long packId);
    Task RemoveByPackIdAsync(long packId);
}
