
using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Command.CarReservation;
using CarRental.Infrastructure.Services;
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
        
        public HomeController(ICommandDispatcher commandDispatcher)
            :base(commandDispatcher)
        {

        }
        public async Task<ActionResult> Index()
        {
            await CommandDispatcher.DispatchAsync(new CreateCarReservation());
            return View();
        }
    }
}