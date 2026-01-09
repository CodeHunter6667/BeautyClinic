using BeautyClinic.Core.Base;

namespace BeautyClinic.Core.Models.Procedure;

public class ProcedurePackProcedure : BaseEntity
{
    public long ProcedurePackId { get; set; }
    public ProcedurePack ProcedurePack { get; set; } = null!;

    public long ProcedureId { get; set; }
    public Procedure Procedure { get; set; } = null!;
}
