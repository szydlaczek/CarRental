using System.Web.Mvc;

namespace CarRental.Web.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ErrorController()
        {
        }

        public ActionResult NoPageFound()
        {
            return View();
        }
    }
}