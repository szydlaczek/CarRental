using Autofac;
using CarRental.Infrastructure.Services;
using CarRental.Infrastructure.Services.CarReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.IOC.Modules
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(ServiceModule).GetTypeInfo().Assembly;
            //builder.RegisterAssemblyTypes(assembly)
            //    .Where(x => x.IsAssignableTo<IService>())
            //    .AsSelf()
            //    .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(assembly)
            .Where(t => t.IsSubclassOf(typeof(CarReservation)))
            .AsSelf();
        }
    }
}
