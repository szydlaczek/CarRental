﻿using Autofac;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.IOC.Modules
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(RepositoryModule).GetTypeInfo().Assembly;

            //builder.RegisterAssemblyTypes(assembly)
            //    .Where(x => x.IsAssignableTo<IRepository>())
            //    .AsImplementedInterfaces()
            //    .InstancePerLifetimeScope();

        }
    }
}
