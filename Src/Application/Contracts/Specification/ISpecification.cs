using Domain.Entities.Base;
using System.Linq.Expressions;

namespace Application.Contracts.Specificationl;

public interface ISpecification<T> where T : BaseEntity
{
    Expression<Func<T , bool>> Predicate { get; }
    List<Expression<Func<T , object>>> Includes { get; }
}
