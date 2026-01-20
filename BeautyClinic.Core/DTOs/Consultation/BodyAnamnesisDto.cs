using BeautyClinic.Core.DTOs.Patient;

namespace BeautyClinic.Core.DTOs.Consultation;

public class BodyAnamnesisDto
{
    public long Id { get; set; }
    public long ClientId { get; set; }
    public string MainComplaints { get; set; } = string.Empty;
    public MeasurementsDto Measurement { get; set; } = new();
    public FemaleHabitsDto FemaleHabits { get; set; } = new();
    public HabitsDto Habits { get; set; } = new();
    public PatientHistoryDto PatientHistory { get; set; } = new();
    public long MeasurementId { get; set; }
    public string ChosenTreatmentNotes { get; set; } = string.Empty;
    public DateTime AssessmentDate { get; set; } = DateTime.Now;
    public string Notes { get; set; } = string.Empty;
}
