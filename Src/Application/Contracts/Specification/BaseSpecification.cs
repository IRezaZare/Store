using Application.Contracts.Specificationl;
using Domain.Entities.Base;
using System.Linq.Expressions;

namespace Application.Contracts.Specification;

public class BaseSpecification<T> : ISpecification<T> where T : BaseEntity
{
    public List<Expression<Func<T, object>>> Includes { get; } = new();
    public Expression<Func<T, bool>> Predicate { get; }


    public BaseSpecification()
    {
        
    }
    public BaseSpecification(Expression<Func<T,bool>> criteria)
    {
        Predicate = criteria;
    }
    protected void Addinclude (Expression<Func<T , object>> include)
    {
        Includes.Add(include); 
    }
}
