using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Command
{
    public interface ICommandHandler<TParameter> where TParameter : ICommand
    {
        Task<CommandResult> HandleAsync(TParameter command);
    }
}
