using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Converters
{
    public static class DateFromString
    {
        public static bool Convert(string dateText, out DateTime destination)
        {
            var result=DateTime.TryParseExact(dateText, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out destination);
            return result;
        }
    }
}
