using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TechnicalIssueHandler.Core.Entities;
using TechnicalIssueHandler.Core.RepositoryInterfaces;
using TechnicalIssueHandler.DAL.Context;

namespace TechnicalIssueHandler.DAL.RepositoryImplements
{
    public class GenericRepository<T>(AppDbContext _context) : IGenericRepository<T> where T : BaseEntity, new()
    {
        protected DbSet<T> Table = _context.Set<T>();
        public async Task CreateAsync(T entity)
            => await Table.AddAsync(entity);

        public async Task DeleteAsync(T entity)
            => await Task.Run(() => Table.Remove(entity));

        public async Task DeleteAsync(Guid id)
            => await DeleteAsync(await GetByIdAsync(id));

        public IQueryable<T> GetAll()
            => Table.AsQueryable();

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
            => Table.Where(expression);

        public async Task<T?> GetByIdAsync(Guid id)
            => await Table.FindAsync(id);

        public void SaveChanges()
            => _context.SaveChanges();
    }
}