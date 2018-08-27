using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Query;
using CarRental.Infrastructure.ViewModel;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CarRental.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
            : base(commandDispatcher, queryDispatcher)
        {
        }

        public async Task<ActionResult> Index()
        {
            //var re = await CommandDispatcher.DispatchAsync<CreateCarReservation>(new CreateCarReservation());
            var r = QueryDispatcher.DispatchAll<CarTypeViewModel>();
            return View();
        }
    }
}