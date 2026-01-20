using BeautyClinic.Core.DTOs.Patient;
using BeautyClinic.Core.Models.Patient;

namespace BeautyClinic.Core.Extensions;

public static class FemaleHabitsExtension
{
    public static FemaleHabitsDto MapToDto(this FemaleHabits entity)
    {
        return new FemaleHabitsDto()
        {
            ClientId =  entity.ClientId,
            Id = entity.Id,
            AcidsUsed = entity.AcidsUsed,
            AlcoholConsumptionFrequency = entity.AlcoholConsumptionFrequency,
            BalencedDiet = entity.BalencedDiet,
            Breastfeeding = entity.Breastfeeding,
            ConsumesAlcoholicBeverage = entity.ConsumesAlcoholicBeverage,
            HasChildren = entity.HasChildren,
            NumberOfChildren = entity.NumberOfChildren,
            PhysicalActivityDaysPerWeek = entity.PhysicalActivityDaysPerWeek,
            PracticesPhysicalActivities = entity.PracticesPhysicalActivities,
            Pregnant = entity.Pregnant,
            RegularBowels = entity.RegularBowels,
            RegularContraceptiveUse = entity.RegularContraceptiveUse,
            RegularMenstrualCycle = entity.RegularMenstrualCycle,
            RegularSleep = entity.RegularSleep,
            Smoker = entity.Smoker,
            UseAcidOnSkin = entity.UseAcidOnSkin,
            UsesDailySunscreen = entity.UsesDailySunscreen,
        };
    }
    
    public static FemaleHabits MapToEntity(this FemaleHabitsDto dto)
    {
        return new FemaleHabits()
        {
            ClientId =  dto.ClientId,
            Id = dto.Id,
            AcidsUsed = dto.AcidsUsed,
            AlcoholConsumptionFrequency = dto.AlcoholConsumptionFrequency,
            BalencedDiet = dto.BalencedDiet,
            Breastfeeding = dto.Breastfeeding,
            ConsumesAlcoholicBeverage = dto.ConsumesAlcoholicBeverage,
            HasChildren = dto.HasChildren,
            NumberOfChildren = dto.NumberOfChildren,
            PhysicalActivityDaysPerWeek = dto.PhysicalActivityDaysPerWeek,
            PracticesPhysicalActivities = dto.PracticesPhysicalActivities,
            Pregnant = dto.Pregnant,
            RegularBowels = dto.RegularBowels,
            RegularContraceptiveUse = dto.RegularContraceptiveUse,
            RegularMenstrualCycle = dto.RegularMenstrualCycle,
            RegularSleep = dto.RegularSleep,
            Smoker = dto.Smoker,
            UseAcidOnSkin = dto.UseAcidOnSkin,
            UsesDailySunscreen = dto.UsesDailySunscreen,
        };
    }
}