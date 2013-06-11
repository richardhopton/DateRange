using System;

namespace DateRange.Units
{
    internal class Day : Unit
    {
        protected internal override DateTime GetUnitOffsetDateTime(DateTime dateTime, Int32 offset)
        {
            return dateTime.AddDays(offset);
        }

        protected override DateTime GetBaseDateTime(DateTime dateTime)
        {
            return dateTime.Date;
        }
    }
}