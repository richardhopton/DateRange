using System;

namespace DateRange.Units
{
    internal class Year : Unit
    {
        public Year(DateTime dateTime)
            : base(dateTime)
        {
        }

        protected internal override DateTime GetUnitOffsetDateTime(DateTime dateTime, int offset)
        {
            return dateTime.AddYears(offset);
        }

        protected override DateTime GetBaseDateTime(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, 1, 1);
        }
    }
}