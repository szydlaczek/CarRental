using System.Threading.Tasks;

namespace CarRental.Infrastructure.Command
{
    public interface ICommandDispatcher
    {
        Task<CommandResult> DispatchAsync<TParameter>(TParameter command) where TParameter : ICommand;
    }
}