
using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;
using CarRental.Infrastructure.Query;
using CarRental.Infrastructure.Query.CarReservation;
using CarRental.Infrastructure.Services;
using CarRental.Infrastructure.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CarRental.Web.Controllers
{
    public class HomeController : BaseController
    {
        
        public HomeController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
            :base(commandDispatcher, queryDispatcher)
        {

        }
        public async Task<ActionResult> Index()
        {
            var re = await CommandDispatcher.DispatchAsync<CreateCarReservation>(new CreateCarReservation());

            return View();

        }
    }
}