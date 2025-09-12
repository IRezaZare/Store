using Domain.Entities.Base;
using System.Linq.Expressions;

namespace Application.Contracts;

public interface IGenericRepositry<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellationToken);
    Task<T> AddAsync(T entity, CancellationToken cancellationToken);
    Task<T> UpdateAsync(T entity);
    Task Delete(T entity, CancellationToken cancellationToken);
    Task<bool> AnyAcync(Expression<Func<T, bool>> expression , CancellationToken cancellationToken );
    Task<bool> AnyAcync(CancellationToken cancellationToken);
}
