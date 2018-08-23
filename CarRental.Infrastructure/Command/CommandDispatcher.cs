using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Command
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IComponentContext _context;
        public CommandDispatcher(IComponentContext context)
        {
            _context = context;
        }
        public async Task<CommandResult> DispatchAsync<TParameter>(TParameter command) where TParameter : ICommand
        {
            if (command == null)
                throw new ArgumentNullException(nameof(command), $"Command {typeof(TParameter).Name} cannot be null");
            var handler = _context.Resolve<ICommandHandler<TParameter>>();
            return await handler.HandleAsync(command);
        }
    }
}
