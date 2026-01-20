using BeautyClinic.Core.DTOs.Patient;
using BeautyClinic.Core.Models.Patient;

namespace BeautyClinic.Core.Extensions;

public static class HabitsExtension
{
    public static HabitsDto MapToDto(this Models.Patient.Habits habits)
    {
        return new HabitsDto
        {
            Id = habits.Id,
            ClientId = habits.ClientId,
            AcidsUsed = habits.AcidsUsed,
            AlcoholConsumptionFrequency = habits.AlcoholConsumptionFrequency,
            BalencedDiet = habits.BalencedDiet,
            ConsumesAlcoholicBeverage = habits.ConsumesAlcoholicBeverage,
            PhysicalActivityDaysPerWeek = habits.PhysicalActivityDaysPerWeek,
            PracticesPhysicalActivities = habits.PracticesPhysicalActivities,
            RegularBowels = habits.RegularBowels,
            RegularSleep = habits.RegularSleep,
            Smoker = habits.Smoker,
            UseAcidOnSkin = habits.UseAcidOnSkin,
            UsesDailySunscreen = habits.UsesDailySunscreen,
        };
    }
    
    public static Habits MapToEntity(this HabitsDto dto)
    {
        return new Habits
        {
            Id = dto.Id,
            ClientId = dto.ClientId,
            AcidsUsed = dto.AcidsUsed,
            AlcoholConsumptionFrequency = dto.AlcoholConsumptionFrequency,
            BalencedDiet = dto.BalencedDiet,
            ConsumesAlcoholicBeverage = dto.ConsumesAlcoholicBeverage,
            PhysicalActivityDaysPerWeek = dto.PhysicalActivityDaysPerWeek,
            PracticesPhysicalActivities = dto.PracticesPhysicalActivities,
            RegularBowels = dto.RegularBowels,
            RegularSleep = dto.RegularSleep,
            Smoker = dto.Smoker,
            UseAcidOnSkin = dto.UseAcidOnSkin,
            UsesDailySunscreen = dto.UsesDailySunscreen,
        };
    }
}