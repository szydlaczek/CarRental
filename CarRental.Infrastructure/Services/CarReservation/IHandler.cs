using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Services.CarReservation
{
    public interface IHandler<T>
    {
        void SetSuccesor(IHandler<T> handler);
        void HandleRequest(T o);
    }
}
