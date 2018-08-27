using Autofac;
using CarRental.Infrastructure.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.IOC.Modules
{
    public class DbContextModule :Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            

            builder.RegisterType<ApplicationContext>().AsSelf().InstancePerRequest();
                              

        }
    }
}
