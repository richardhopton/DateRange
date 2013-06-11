using System;

namespace DateRange.Units
{
    internal class Quarter : Unit
    {
        public Quarter(DateTime dateTime)
            : base(dateTime)
        {
        }

        protected internal override DateTime GetUnitOffsetDateTime(DateTime dateTime, int offset)
        {
            return dateTime.AddMonths(offset*3);
        }

        protected override DateTime GetBaseDateTime(DateTime dateTime)
        {
            var quarter = Math.Floor(dateTime.Month / 4.0);
            return new DateTime(dateTime.Year, (Int32)((quarter*4)+1), 1);
        }
    }
}