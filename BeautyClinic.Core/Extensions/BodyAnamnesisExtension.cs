using BeautyClinic.Core.DTOs.Consultation;
using BeautyClinic.Core.Models.Consulation;

namespace BeautyClinic.Core.Extensions;

public static class BodyAnamnesisExtension
{
    public static BodyAnamnesisDto MapToDto(this BodyAnamnesis entity)
    {
        return new BodyAnamnesisDto
        {
            Id = entity.Id,
            AssessmentDate =  entity.AssessmentDate,
            Notes =  entity.Notes,
            ClientId =  entity.ClientId,
            ChosenTreatmentNotes =  entity.ChosenTreatmentNotes,
            MainComplaints =  entity.MainComplaints,
            MeasurementId =   entity.MeasurementId
        };
    }
    
    public static BodyAnamnesis MapToEntity(this BodyAnamnesisDto dto)
    {
        return new BodyAnamnesis
        {
            Id = dto.Id,
            AssessmentDate =  dto.AssessmentDate,
            Notes =  dto.Notes,
            ClientId =  dto.ClientId,
            ChosenTreatmentNotes =  dto.ChosenTreatmentNotes,
            MainComplaints =  dto.MainComplaints,
            MeasurementId =   dto.MeasurementId
        };
    }
}