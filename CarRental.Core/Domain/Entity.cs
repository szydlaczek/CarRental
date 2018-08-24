using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Domain
{
    public interface Entity<TKey> where TKey : struct
    {
        TKey Id { get;}
    }
}
