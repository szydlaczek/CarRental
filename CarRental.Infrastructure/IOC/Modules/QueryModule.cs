using Autofac;
using CarRental.Infrastructure.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.IOC.Modules
{
    public class QueryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(QueryModule).GetTypeInfo().Assembly;

            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(IQueryHandler<>))
                .InstancePerLifetimeScope();

            builder.RegisterType<QueryDispatcher>()
                 .As<IQueryDispatcher>()
                 .InstancePerLifetimeScope();

        }
    }
}
