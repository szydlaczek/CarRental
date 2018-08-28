using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Query;
using System.Web.Mvc;

namespace CarRental.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly ICommandDispatcher CommandDispatcher;
        protected readonly IQueryDispatcher QueryDispatcher;

        // GET: Base
        public BaseController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            CommandDispatcher = commandDispatcher;
            QueryDispatcher = queryDispatcher;
        }
        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }
    }
}