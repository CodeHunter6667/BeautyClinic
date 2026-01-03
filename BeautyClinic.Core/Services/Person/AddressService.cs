using BeautyClinic.Core.Interfaces.Person;
using BeautyClinic.Core.Models.Person;
using BeautyClinic.Core.Services;
using BeautyClinic.Core.ValueObjects;

namespace BeautyClinic.Core.Services.Person;

public class AddressService : BaseService<Address>, IAddressService
{
    public AddressService(IAddressRepository repository) : base(repository)
    {
    }
}
