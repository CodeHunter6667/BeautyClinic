using BeautyClinic.Core.DTOs.Patient;
using BeautyClinic.Core.Models.Patient;

namespace BeautyClinic.Core.Extensions;

public static class PatientHistoryExtension
{
    public static PatientHistoryDto MapToDto(this PatientHistory entity)
    {
        return new PatientHistoryDto
        {
            Id = entity.Id,
            ClientId = entity.ClientId,
            Allergies = entity.Allergies,
            PreviousTreatments = entity.PreviousTreatments,
            DentalProstheses = entity.DentalProstheses,
            Epilepsy = entity.Epilepsy,
            HeartProblem = entity.HeartProblem,
            Hypertension = entity.Hypertension,
            MetalProstheses = entity.MetalProstheses,
            OncologicalTreatments = entity.OncologicalTreatments,
            Pacemaker = entity.Pacemaker,
            UnderMedicalTreatment = entity.UnderMedicalTreatment,
        };
    }

    public static PatientHistory MapToEntity(this PatientHistoryDto dto)
    {
        return new PatientHistory()
        {
            Id = dto.Id,
            ClientId = dto.ClientId,
            Allergies = dto.Allergies,
            PreviousTreatments = dto.PreviousTreatments,
            DentalProstheses = dto.DentalProstheses,
            Epilepsy = dto.Epilepsy,
            HeartProblem = dto.HeartProblem,
            Hypertension = dto.Hypertension,
            MetalProstheses = dto.MetalProstheses,
            OncologicalTreatments = dto.OncologicalTreatments,
            Pacemaker = dto.Pacemaker,
            UnderMedicalTreatment = dto.UnderMedicalTreatment,
        };
    }
    
}