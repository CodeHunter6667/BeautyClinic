using BeautyClinic.Core.Interfaces.Consulation;
using BeautyClinic.Core.Models.Consulation;
using BeautyClinic.Infrastructure.Context;
using BeautyClinic.Infrastructure.Repositories;

namespace BeautyClinic.Infrastructure.Repositories.Consulation;

public class BodyAnamnesisRepository : Repository<BodyAnamnesis>, IBodyAnamnesisRepository
{
    public BodyAnamnesisRepository(AppDbContext context) : base(context)
    {
    }
}
