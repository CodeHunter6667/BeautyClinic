using BeautyClinic.Core.Interfaces.Consulation;
using BeautyClinic.Core.Models.Consulation;
using BeautyClinic.Core.Services;

namespace BeautyClinic.Core.Services.Consulation;

public class BodyAnamnesisService : BaseService<BodyAnamnesis>, IBodyAnamnesisService
{
    public BodyAnamnesisService(IBodyAnamnesisRepository repository) : base(repository)
    {
    }
}
