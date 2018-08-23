using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Query
{
    public interface IQueryDispatcher
    {
        Task<TResult> Dispatch<TParametr, TResult>(TParametr query) where TParametr : IQuery where TResult IQueryResult
    }
}
