using System;
using DateRange.Units;

namespace DateRange.Places
{
    internal class End : Place
    {
        public override DateTime GetOffsetDateTime(DateTime dateTime, Unit unit)
        {
            return unit.GetUnitOffsetDateTime(dateTime, 1).AddMilliseconds(-1);
        }
    }
}