using System.Linq.Expressions;
using BeautyClinic.Core.Base;
using BeautyClinic.Core.Interfaces;

namespace BeautyClinic.Core.Services;

public class BaseService<T> : IService<T> where T : BaseEntity
{
    protected readonly IRepository<T> _repository;
    protected readonly IUnitOfWork _unitOfWork;

    public BaseService(IRepository<T> repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
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
        await ExecuteWithCommitAsync(() => _repository.AddAsync(entity));
    }

    public virtual async Task UpdateAsync(T entity)
    {
        await ExecuteWithCommitAsync(() =>
        {
            _repository.Update(entity);
            return Task.CompletedTask;
        });
    }

    public virtual async Task RemoveAsync(long id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity != null)
        {
            await ExecuteWithCommitAsync(() =>
            {
                _repository.Remove(entity);
                return Task.CompletedTask;
            });
        }
    }

    /// <summary>
    /// Execute a write operation followed by a commit (no transaction).
    /// </summary>
    protected async Task ExecuteWithCommitAsync(Func<Task> action)
    {
        await action();
        await _unitOfWork.CommitAsync();
    }

    /// <summary>
    /// Execute a multi-step operation inside a transaction; use when touching multiple repositories.
    /// </summary>
    protected async Task ExecuteInTransactionAsync(Func<Task> action)
    {
        await _unitOfWork.BeginTransactionAsync();
        try
        {
            await action();
            await _unitOfWork.CommitTransactionAsync();
        }
        catch
        {
            await _unitOfWork.RollbackTransactionAsync();
            throw;
        }
    }
}
