using System;

namespace DateRange.Units
{
    internal class Hour : Unit
    {
        public Hour(DateTime dateTime)
            : base(dateTime)
        {
        }

        protected internal override DateTime GetUnitOffsetDateTime(DateTime dateTime, int offset)
        {
            return dateTime.AddHours(offset);
        }

        protected override DateTime GetBaseDateTime(DateTime dateTime)
        {
            return dateTime.Date.AddHours(dateTime.Hour);
        }
    }
}