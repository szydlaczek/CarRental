using CarRental.Infrastructure.Query;

namespace CarRental.Infrastructure.ViewModel
{
    public class CarTypeViewModel : IQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}