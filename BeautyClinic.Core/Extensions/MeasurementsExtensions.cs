using BeautyClinic.Core.DTOs.Patient;
using BeautyClinic.Core.Models.Patient;

namespace BeautyClinic.Core.Extensions;

public static  class MeasurementsExtensions
{
    public static MeasurementsDto MapToDto(this Models.Patient.Measurements entity)
    {
        return new MeasurementsDto
        {
            Id = entity.Id,
            Weight = entity.Weight,
            Height = entity.Height,
            ClientId = entity.ClientId,
            Bust = entity.Bust,
            Hip = entity.Hip,
            LeftArm = entity.LeftArm,
            LeftCalf = entity.LeftCalf,
            LeftThigh = entity.LeftThigh,
            MeasurementDate = entity.MeasurementDate,
            RightArm = entity.RightArm,
            RightCalf = entity.RightCalf,
            RightThigh = entity.RightThigh,
            UpperAbdomen = entity.UpperAbdomen,
        };
    }
    
    public static Measurements MapToEntity(this MeasurementsDto dto)
    {
        return new Measurements
        {
            Id = dto.Id,
            Weight = dto.Weight,
            Height = dto.Height,
            ClientId = dto.ClientId,
            Bust = dto.Bust,
            Hip = dto.Hip,
            LeftArm = dto.LeftArm,
            LeftCalf = dto.LeftCalf,
            LeftThigh = dto.LeftThigh,
            MeasurementDate = dto.MeasurementDate,
            RightArm = dto.RightArm,
            RightCalf = dto.RightCalf,
            RightThigh = dto.RightThigh,
            UpperAbdomen = dto.UpperAbdomen,
        };
    }
}