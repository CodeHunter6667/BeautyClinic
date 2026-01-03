using System.Linq.Expressions;
using BeautyClinic.Core.Base;
using BeautyClinic.Core.Interfaces;

namespace BeautyClinic.Core.Services;

public class BaseService<T> : IService<T> where T : BaseEntity
{
    protected readonly IRepository<T> _repository;

    public BaseService(IRepository<T> repository)
    {
        _repository = repository;
    }

    public virtual async Task<T?> GetByIdAsync(long id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        return await _repository.FindAsync(predicate);
    }

    public virtual async Task AddAsync(T entity)
    {
        await _repository.AddAsync(entity);
    }

    public virtual async Task UpdateAsync(T entity)
    {
        _repository.Update(entity);
        await Task.CompletedTask;
    }

    public virtual async Task RemoveAsync(long id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity != null)
        {
            _repository.Remove(entity);
        }
    }
}
