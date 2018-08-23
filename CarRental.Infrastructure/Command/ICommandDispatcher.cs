using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Command
{    
        public interface ICommandDispatcher
        {
            Task DispatchAsync<T>(T Command) where T : ICommand;
        }    
}
