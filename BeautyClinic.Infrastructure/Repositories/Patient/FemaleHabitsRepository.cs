using BeautyClinic.Core.DTOs.Patient;
using BeautyClinic.Core.Exceptions;
using BeautyClinic.Core.Extensions;
using BeautyClinic.Core.Interfaces.Patient;
using BeautyClinic.Core.Models.Patient;
using BeautyClinic.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BeautyClinic.Infrastructure.Repositories.Patient;

public class FemaleHabitsRepository(AppDbContext context) : Repository<FemaleHabits>(context), IFemaleHabitsRepository
{
    public async Task<FemaleHabitsDto> GetFemaleHabitsByClientId(long clientId)
    {
        var entity = await context.FemaleHabits.AsNoTracking().FirstOrDefaultAsync(x => x.ClientId == clientId);
        if (entity is null)
            throw new ResourceNotFoundException("Hábitos não encontrados para o cliente informado.");
        
        var femaleHabitsDto = entity.MapToDto();
        return femaleHabitsDto;
    }
}
