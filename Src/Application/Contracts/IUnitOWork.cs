using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Application.Contracts;
 
public interface IUnitOWork
{
    DbContext context { get; }
    Task<int> Save(CancellationToken cancellationToken);
    IGenericRepositry<T> Repository<T>() where T : BaseEntity;
}
