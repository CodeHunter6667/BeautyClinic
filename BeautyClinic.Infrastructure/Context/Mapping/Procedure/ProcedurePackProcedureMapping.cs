using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeautyClinic.Infrastructure.Context.Mapping.Procedure;

public class ProcedurePackProcedureMapping : IEntityTypeConfiguration<Core.Models.Procedure.ProcedurePackProcedure>
{
    public void Configure(EntityTypeBuilder<Core.Models.Procedure.ProcedurePackProcedure> builder)
    {
        builder.HasKey(ppp => new { ppp.ProcedurePackId, ppp.ProcedureId });

        builder.HasOne(ppp => ppp.ProcedurePack)
            .WithMany(pp => pp.ProcedurePackProcedures)
            .HasForeignKey(ppp => ppp.ProcedurePackId);

        builder.HasOne(ppp => ppp.Procedure)
            .WithMany(p => p.ProcedurePackProcedures)
            .HasForeignKey(ppp => ppp.ProcedureId);

        builder.Property(ppp => ppp.Quantity)
        .IsRequired();
    }
}