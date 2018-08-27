using Autofac;
using CarRental.Infrastructure.Services;
using System.Linq;
using System.Reflection;

namespace CarRental.Infrastructure.IOC.Modules
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(ServiceModule).GetTypeInfo().Assembly;
            builder.RegisterAssemblyTypes(assembly)
                .Where(x => x.IsAssignableTo<IService>())
                .AsImplementedInterfaces()
                .InstancePerRequest();
        }
    }
}