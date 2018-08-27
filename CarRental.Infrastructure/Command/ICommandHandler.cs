using System.Threading.Tasks;

namespace CarRental.Infrastructure.Command
{
    public interface ICommandHandler<TParameter> where TParameter : ICommand
    {
        Task<CommandResult> HandleAsync(TParameter command);
    }
}