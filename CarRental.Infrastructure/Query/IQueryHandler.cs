using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Query
{
    public interface IQueryHandler<TParameter, TResult>
        where TResult : IQueryResult
        where TParameter : IQuery
    {
        Task<TResult> Retrieve(TParameter query);
        
    }
    public interface IQueryHandler<TResult>
        where TResult : IQueryResult
        
    {
        Task<TResult> Retrieve();

    }
    
}
