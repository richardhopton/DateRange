using System;
using DateRange.Units;

namespace DateRange.Places
{
    internal class Start : Place
    {
        public override DateTime GetOffsetDateTime(DateTime dateTime, Unit unit)
        {
            return dateTime;
        }
    }
}