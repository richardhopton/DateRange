using System;

namespace DateRange.Units
{
    internal class Week : Unit
    {
        public Week(DateTime dateTime) : base(dateTime)
        {
        }

        protected internal override DateTime GetUnitOffsetDateTime(DateTime dateTime, int offset)
        {
            return dateTime.AddDays(offset*7);
        }

        protected override DateTime GetBaseDateTime(DateTime dateTime)
        {
            return dateTime.AddDays(1 - (Int32)dateTime.DayOfWeek).Date;
        }
    }
}