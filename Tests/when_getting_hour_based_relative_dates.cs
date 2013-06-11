using System;
using DateRange.Places;
using DateRange.Tenses;
using DateRange.Units;
using NUnit.Framework;

namespace DateRange.Tests
{
    [TestFixture]
    public class when_getting_hour_based_relative_dates
    {
        private readonly DateTime _dateTime = new DateTime(2013, 02, 27, 12, 22, 54, 154);

        private readonly DateTime _thisHourStart = new DateTime(2013, 02, 27, 12, 0, 0);
        private readonly DateTime _thisHourEnd = new DateTime(2013, 02, 27, 12, 59, 59, 999);
        private readonly DateTime _nextHourStart = new DateTime(2013, 02, 27, 13, 0, 0);
        private readonly DateTime _nextHourEnd = new DateTime(2013, 02, 27, 13, 59, 59, 999);
        private readonly DateTime _prevHourStart = new DateTime(2013, 02, 27, 11, 0, 0);
        private readonly DateTime _prevHourEnd = new DateTime(2013, 02, 27, 11, 59, 59, 999);

        [Test]
        public void should_correctly_calculate_this_hour_start()
        {
            var tense = new This();
            var place = new Start();
            var unit = new Hour(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_thisHourStart));
        }

        [Test]
        public void should_correctly_calculate_this_hour_end()
        {
            var tense = new This();
            var place = new End();
            var unit = new Hour(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_thisHourEnd));
        }

        [Test]
        public void should_correctly_calculate_next_hour_start()
        {
            var tense = new Next();
            var place = new Start();
            var unit = new Hour(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_nextHourStart));
        }

        [Test]
        public void should_correctly_calculate_next_hour_end()
        {
            var tense = new Next();
            var place = new End();
            var unit = new Hour(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_nextHourEnd));
        }

        [Test]
        public void should_correctly_calculate_prev_hour_start()
        {
            var tense = new Prev();
            var place = new Start();
            var unit = new Hour(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_prevHourStart));
        }

        [Test]
        public void should_correctly_calculate_prev_hour_end()
        {
            var tense = new Prev();
            var place = new End();
            var unit = new Hour(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_prevHourEnd));
        }
    }
}