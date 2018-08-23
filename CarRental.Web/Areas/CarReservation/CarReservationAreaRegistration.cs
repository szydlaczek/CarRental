using System.Web.Mvc;

namespace CarRental.Web.Areas.CarReservation
{
    public class CarReservationAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CarReservation";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CarReservation_default",
                "CarReservation/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}