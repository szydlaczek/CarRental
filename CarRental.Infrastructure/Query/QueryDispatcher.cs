using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Query
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IComponentContext _context;
        public QueryDispatcher(IComponentContext context)
        {
            _context = context;
        }
        public Task<TResult> Dispatch<TParametr, TResult>(TParametr query)
        {
            var handler=
        }
    }
}
