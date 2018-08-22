using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace CarRental.Infrastructure.IOC.Modules
{
    public class ContainerModule : Autofac.Module
    {

        public ContainerModule()
        {

        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<ServiceModule>();
        }
    }
}
