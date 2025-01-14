using System.Linq.Expressions;
using TechnicalIssueHandler.Core.Entities;

namespace TechnicalIssueHandler.Core.RepositoryInterfaces;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    IQueryable<T> GetAll();
    IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
    Task<T?> GetByIdAsync(Guid id);
    Task CreateAsync(T entity);
    Task DeleteAsync(T entity);
    Task DeleteAsync(Guid id);
    void SaveChanges();
}
