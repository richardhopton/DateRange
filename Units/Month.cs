using System;

namespace DateRange.Units
{
    internal class Month : Unit
    {
        public Month(DateTime dateTime)
            : base(dateTime)
        {
        }

        protected internal override DateTime GetUnitOffsetDateTime(DateTime dateTime, int offset)
        {
            return dateTime.AddMonths(offset);
        }

        protected override DateTime GetBaseDateTime(DateTime dateTime)
        {
            return dateTime.AddDays(1 - dateTime.Day).Date;
        }
    }
}