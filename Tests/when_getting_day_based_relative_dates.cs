using System;
using DateRange.Places;
using DateRange.Tenses;
using DateRange.Units;
using NUnit.Framework;

namespace DateRange.Tests
{
    [TestFixture]
    public class when_getting_day_based_relative_dates
    {
        private readonly DateTime _dateTime = new DateTime(2013, 02, 27, 12, 22, 54, 154);

        private readonly DateTime _thisDayStart = new DateTime(2013, 02, 27);
        private readonly DateTime _thisDayEnd = new DateTime(2013, 02, 27, 23, 59, 59, 999);
        private readonly DateTime _nextDayStart = new DateTime(2013, 02, 28);
        private readonly DateTime _nextDayEnd = new DateTime(2013, 02, 28, 23, 59, 59, 999);
        private readonly DateTime _prevDayStart = new DateTime(2013, 02, 26);
        private readonly DateTime _prevDayEnd = new DateTime(2013, 02, 26, 23, 59, 59, 999);

        [Test]
        public void should_correctly_calculate_this_day_start()
        {
            var tense = new This();
            var place = new Start();
            var unit = new Day();
            var dt = unit.GetDateTime(tense, place);
            var dateTime = DateTime.UtcNow.Date;
            Assert.That(dt, Is.EqualTo(dateTime));
        }

        [Test]
        public void should_correctly_calculate_this_day_end()
        {
            var tense = new This();
            var place = new End();
            var unit = new Day();
            var dt = unit.GetDateTime(tense, place);
            var dateTime = DateTime.UtcNow.Date.AddDays(1).AddMilliseconds(-1);
            Assert.That(dt, Is.EqualTo(dateTime));
        }

        [Test]
        public void should_correctly_calculate_next_day_start()
        {
            var tense = new Next();
            var place = new Start();
            var unit = new Day();
            var dt = unit.GetDateTime(tense, place);
            var dateTime = DateTime.UtcNow.Date.AddDays(1);
            Assert.That(dt, Is.EqualTo(dateTime));
        }

        [Test]
        public void should_correctly_calculate_next_day_end()
        {
            var tense = new Next();
            var place = new End();
            var unit = new Day();
            var dt = unit.GetDateTime(tense, place);
            var dateTime = DateTime.UtcNow.Date.AddDays(2).AddMilliseconds(-1);
            Assert.That(dt, Is.EqualTo(dateTime));
        }

        [Test]
        public void should_correctly_calculate_prev_day_start()
        {
            var tense = new Prev();
            var place = new Start();
            var unit = new Day();
            var dt = unit.GetDateTime(tense, place);
            var dateTime = DateTime.UtcNow.Date.AddDays(-1);
            Assert.That(dt, Is.EqualTo(dateTime));
        }

        [Test]
        public void should_correctly_calculate_prev_day_end()
        {
            var tense = new Prev();
            var place = new End();
            var unit = new Day();
            var dt = unit.GetDateTime(tense, place);
            var dateTime = DateTime.UtcNow.Date.AddMilliseconds(-1);
            Assert.That(dt, Is.EqualTo(dateTime));
        }
    }
}