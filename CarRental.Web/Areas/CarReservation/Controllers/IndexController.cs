
using CarRental.Infrastructure.Command;
using CarRental.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental.Web.Controllers
{
    public class IndexController : BaseController
    {
        
        public IndexController(ICommandDispatcher commandDispatcher)
            :base(commandDispatcher)
        {

        }
        
    }
}