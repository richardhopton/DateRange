using System;
using DateRange.Units;

namespace DateRange.Places
{
    internal abstract class Place
    {
        public abstract DateTime GetOffsetDateTime(DateTime dateTime, Unit unit);
    }
}