using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Query
{
    public interface IQueryDispatcher
    {
        Task<TResult> Dispatch<TParametr, TResult>(TParametr query) where TParametr : IQuery where TResult : IQueryResult;

        Task<IEnumerable<TResult>> DispatchAll<TResult>() where TResult : IQueryResult;
    }
}