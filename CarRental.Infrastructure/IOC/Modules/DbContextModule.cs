using Autofac;
using CarRental.Infrastructure.ApplicationDbContext;

namespace CarRental.Infrastructure.IOC.Modules
{
    public class DbContextModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationContext>().AsImplementedInterfaces().InstancePerRequest();
        }
    }
}