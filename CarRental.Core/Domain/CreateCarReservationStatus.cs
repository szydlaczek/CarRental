﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Domain
{
    public enum CreateCarReservationResult
    {
        Success,
        MaxCarPerDayExExceeded
    }
}