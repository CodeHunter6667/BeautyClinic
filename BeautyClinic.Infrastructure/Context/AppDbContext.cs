using System.Reflection;
using BeautyClinic.Core.Base;
using BeautyClinic.Core.Models.Person;
using BeautyClinic.Core.Models.Procedure;
using Microsoft.EntityFrameworkCore;

namespace BeautyClinic.Infrastructure.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // DbSets for entities - add others as needed
    public DbSet<ProcedurePack> ProcedurePacks { get; set; } = null!;
    public DbSet<Procedure> Procedures { get; set; } = null!;
    public DbSet<ProcedurePackProcedure> ProcedurePackProcedures { get; set; } = null!;
    // public DbSet<Individual> Individuals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Apply configurations from this assembly
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // Configure M:N explicit relationship
        modelBuilder.Entity<ProcedurePackProcedure>()
            .HasKey(ppp => new { ppp.ProcedurePackId, ppp.ProcedureId });

        modelBuilder.Entity<ProcedurePackProcedure>()
            .HasOne(ppp => ppp.ProcedurePack)
            .WithMany(pp => pp.ProcedurePackProcedures)
            .HasForeignKey(ppp => ppp.ProcedurePackId);

        modelBuilder.Entity<ProcedurePackProcedure>()
            .HasOne(ppp => ppp.Procedure)
            .WithMany(p => p.ProcedurePackProcedures)
            .HasForeignKey(ppp => ppp.ProcedureId);
    }
}
