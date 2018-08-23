﻿using Autofac;
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
        public async Task<TResult> Dispatch<TParametr, TResult>(TParametr query) where TParametr : IQuery where TResult : IQueryResult
        {
            var handler = _context.ResolveOptional<IQueryHandler<TParametr, TResult>>();
            TResult result = await handler.Retrieve(query);
            return result;

        }
        public async Task<List<TResult>> DispatchAll<TResult>() where TResult : IQueryResult
        {
            var handler = _context.Resolve<IQueryHandler<TResult>>();
            List<TResult> result = await handler.RetrievieAll();
            return result;
        }
        
    }
}