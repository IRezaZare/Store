using Application.Contracts;
using Application.Contracts.Specificationl;
using Domain.Entities.Base;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infrastructure.Persistence;

public class GenericRepository<T> : IGenericRepositry<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;
    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<T> AddAsync(T entity, CancellationToken cancellationToken)
    {
        await _dbSet.AddAsync(entity, cancellationToken);
        return await Task.FromResult(entity);
    }

    public async Task<bool> AnyAcync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
    {
        return await _dbSet.AnyAsync(expression, cancellationToken);
    }

    public async Task<bool> AnyAcync(CancellationToken cancellationToken)
    {
        return await _dbSet.AnyAsync(cancellationToken);

    }

    public async Task Delete(T entity, CancellationToken cancellationToken)
    {
        var record = await GetByIdAsync(entity.Id, cancellationToken);
        record.IsDelete = true;
        await UpdateAsync(entity);
    }

    public async Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _dbSet.ToListAsync(cancellationToken);
    }

    public async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _dbSet.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public Task<T> GetEntityWithSpec(ISpecification<T> spec)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<T>> ListAsyncSpec(ISpecification<T> spec)
    {
        throw new NotImplementedException();
    }

    public Task<T> UpdateAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        return Task.FromResult(entity);
    }
}
