using BeautyClinic.Core.Interfaces;
using BeautyClinic.Core.Interfaces.Procedure;
using BeautyClinic.Core.Models.Procedure;
using BeautyClinic.Core.Services;

namespace BeautyClinic.Core.Services.Procedure;

public class ProcedurePackService : BaseService<ProcedurePack>, IProcedurePackService
{
    public ProcedurePackService(IProcedurePackRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}
