using System.Reflection;
using BeautyClinic.Core.Models.Appointment;
using BeautyClinic.Core.Models.Consulation;
using BeautyClinic.Core.Models.Patient;
using BeautyClinic.Core.Models.Person;
using BeautyClinic.Core.Models.Procedure;
using BeautyClinic.Core.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace BeautyClinic.Infrastructure.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<ProcedurePack> ProcedurePacks { get; set; } = null!;
    public DbSet<Procedure> Procedures { get; set; } = null!;
    public DbSet<ProcedurePackProcedure> ProcedurePackProcedures { get; set; } = null!;
    public DbSet<Individual> Individuals { get; set; }
    public DbSet<Professional> Professionals { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<BodyAnamnesis> BodyAnamnesises { get; set; }
    public DbSet<FacialAnamnesis> FacialAnamnesises { get; set; }
    public DbSet<FemaleHabits> FemaleHabits { get; set; }
    public DbSet<Habits> Habits { get; set; }
    public DbSet<Measurements> Measurements { get; set; }
    public DbSet<PatientHistory> PatientHistories { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
