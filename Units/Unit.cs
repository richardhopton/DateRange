using System;
using DateRange.Places;
using DateRange.Tenses;

namespace DateRange.Units
{
    internal abstract class Unit
    {
        private DateTime _dateTime;

        internal Unit(DateTime dateTime)
        {
            _dateTime = dateTime;
        }

        internal Unit()
            : this(DateTime.UtcNow)
        {
        }

        protected internal abstract DateTime GetUnitOffsetDateTime(DateTime dateTime, Int32 offset);
        protected abstract DateTime GetBaseDateTime(DateTime dateTime);

        public DateTime GetDateTime(Tense tense, Place place)
        {
            var tenseOffset = tense.GetOffset();
            var baseDateTime = GetBaseDateTime(_dateTime);
            var dateTime = GetUnitOffsetDateTime(baseDateTime, tenseOffset);
            return place.GetOffsetDateTime(dateTime, this);
        }
    }
}