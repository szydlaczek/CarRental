﻿
using CarRental.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ICarReservationService carReservationService)
        {

        }
        
    }
}