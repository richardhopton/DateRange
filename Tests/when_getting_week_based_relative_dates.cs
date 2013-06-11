using System;
using DateRange.Places;
using DateRange.Tenses;
using DateRange.Units;
using NUnit.Framework;

namespace DateRange.Tests
{
    [TestFixture]
    public class when_getting_week_based_relative_dates
    {
        private readonly DateTime _dateTime = new DateTime(2013, 02, 27, 12, 22, 54, 154);
        
        private readonly DateTime _thisWeekStart = new DateTime(2013, 02, 25);
        private readonly DateTime _thisWeekEnd = new DateTime(2013, 03, 03, 23, 59, 59, 999);
        private readonly DateTime _nextWeekStart = new DateTime(2013, 03, 04);
        private readonly DateTime _nextWeekEnd = new DateTime(2013, 03, 10, 23, 59, 59, 999);
        private readonly DateTime _prevWeekStart = new DateTime(2013, 02, 18);
        private readonly DateTime _prevWeekEnd = new DateTime(2013, 02, 24, 23, 59, 59, 999);

        [Test]
        public void should_correctly_calculate_this_week_start()
        {
            var tense = new This();
            var place = new Start();
            var unit = new Week(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_thisWeekStart));
        }

        [Test]
        public void should_correctly_calculate_this_week_end()
        {
            var tense = new This();
            var place = new End();
            var unit = new Week(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_thisWeekEnd));
        }

        [Test]
        public void should_correctly_calculate_next_week_start()
        {
            var tense = new Next();
            var place = new Start();
            var unit = new Week(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_nextWeekStart));
        }

        [Test]
        public void should_correctly_calculate_next_week_end()
        {
            var tense = new Next();
            var place = new End();
            var unit = new Week(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_nextWeekEnd));
        }

        [Test]
        public void should_correctly_calculate_prev_week_start()
        {
            var tense = new Prev();
            var place = new Start();
            var unit = new Week(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_prevWeekStart));
        }

        [Test]
        public void should_correctly_calculate_prev_week_end()
        {
            var tense = new Prev();
            var place = new End();
            var unit = new Week(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_prevWeekEnd));
        }
    }
}