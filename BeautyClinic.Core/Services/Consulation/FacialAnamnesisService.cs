using BeautyClinic.Core.Interfaces;
using BeautyClinic.Core.Interfaces.Consulation;
using BeautyClinic.Core.Models.Consulation;
using BeautyClinic.Core.Services;

namespace BeautyClinic.Core.Services.Consulation;

public class FacialAnamnesisService : BaseService<FacialAnamnesis>, IFacialAnamnesisService
{
    public FacialAnamnesisService(IFacialAnamnesisRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}
