using BeautyClinic.Core.Base;

namespace BeautyClinic.Core.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IRepository<T> Repository<T>() where T : BaseEntity;
    Task<int> CompleteAsync();
}
