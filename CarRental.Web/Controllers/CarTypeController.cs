using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;
using CarRental.Infrastructure.Query;
using CarRental.Infrastructure.ViewModel;
using CarRental.Infrastructure.ViewModels;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CarRental.Web.Controllers
{
    public class CarTypeController : BaseController
    {
        public CarTypeController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
            : base(commandDispatcher, queryDispatcher)
        {
        }
        public ActionResult Index()
        {
            return RedirectToAction("CreateCarReservation");
        }
        public async Task<ActionResult> CreateCarReservation()
        {            
            ViewBag.CarTypeList = await QueryDispatcher.DispatchAll<CarTypeViewModel>();
            return View(new CreateCarReservation());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateCarReservation(CreateCarReservation command)
        {
            if (ModelState.IsValid)
            ViewBag.CarTypeList = await QueryDispatcher.DispatchAll<CarTypeViewModel>();
            return View();
        }

    }
}