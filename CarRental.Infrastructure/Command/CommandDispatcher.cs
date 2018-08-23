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
        public async Task DispatchAsync<T>(T Command) where T : ICommand
        {
            if (Command == null)
                throw new ArgumentNullException(nameof(Command), $"Command {typeof(T).Name} cannot be null");
            var handler = _context.Resolve<ICommandHandler<T>>();
            await handler.HandleAsync(Command);
        }
    }
}
