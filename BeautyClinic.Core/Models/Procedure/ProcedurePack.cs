using BeautyClinic.Core.Base;

namespace BeautyClinic.Core.Models.Procedure;

public class ProcedurePack : BaseEntity 
{
    public string PackName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<ProcedurePackProcedure> ProcedurePackProcedures { get; set; } = new();
    public decimal Price { get; set; }
    public bool Active { get; set; }
    public int SessionsQuantity { get; set; }
}
