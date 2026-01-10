using BeautyClinic.Core.Models.Patient;

namespace BeautyClinic.Core.DTOs.Consultation;

public class BodyAnamnesisDto
{
    public long Id { get; set; }
    public long ClientId { get; set; }
    public string MainComplaints { get; set; } = string.Empty;
    public Measurements Measurement { get; set; } = new();
    public long MeasurementId { get; set; }
    public string ChosenTreatmentNotes { get; set; } = string.Empty;
    public DateTime AssessmentDate { get; set; } = DateTime.Now;
    public string Notes { get; set; } = string.Empty;
}
