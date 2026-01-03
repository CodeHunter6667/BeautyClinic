using System.Collections;
using BeautyClinic.Core.Base;
using BeautyClinic.Core.Interfaces;
using BeautyClinic.Infrastructure.Context;
using BeautyClinic.Infrastructure.Repositories;

namespace BeautyClinic.Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private readonly Hashtable _repositories;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        _repositories = new Hashtable();
    }

    public async Task<int> CompleteAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public IRepository<T> Repository<T>() where T : BaseEntity
    {
        var type = typeof(T).Name;

        if (!_repositories.ContainsKey(type))
        {
            var repositoryType = typeof(Repository<>);
            var repositoryInstance = Activator
                .CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
            _repositories.Add(type, repositoryInstance);
        }

        return (IRepository<T>)_repositories[type]!;
    }
}
