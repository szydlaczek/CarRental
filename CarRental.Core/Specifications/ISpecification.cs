using System;
using System.Linq.Expressions;

namespace CarRental.Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Condition { get; }
    }
}