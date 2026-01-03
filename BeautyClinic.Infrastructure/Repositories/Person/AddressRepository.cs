using BeautyClinic.Core.Interfaces.Person;
using BeautyClinic.Core.Models.Person;
using BeautyClinic.Core.ValueObjects;
using BeautyClinic.Infrastructure.Context;
using BeautyClinic.Infrastructure.Repositories;

namespace BeautyClinic.Infrastructure.Repositories.Person;

public class AddressRepository : Repository<Address>, IAddressRepository
{
    public AddressRepository(AppDbContext context) : base(context)
    {
    }
}
