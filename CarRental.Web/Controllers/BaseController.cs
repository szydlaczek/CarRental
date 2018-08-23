using CarRental.Infrastructure.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly ICommandDispatcher CommandDispatcher;
        // GET: Base
        public BaseController(ICommandDispatcher commandDispatcher)
        {
            CommandDispatcher = commandDispatcher;
        }

    }
}