using System;
using DateRange.Places;
using DateRange.Tenses;
using DateRange.Units;
using NUnit.Framework;

namespace DateRange.Tests
{
    [TestFixture]
    public class when_getting_month_based_relative_dates
    {
        private readonly DateTime _dateTime = new DateTime(2013, 02, 27, 12, 22, 54, 154);
        
        private readonly DateTime _thisMonthStart = new DateTime(2013, 02, 01);
        private readonly DateTime _thisMonthEnd = new DateTime(2013, 02, 28, 23, 59, 59, 999);
        private readonly DateTime _nextMonthStart = new DateTime(2013, 03, 01);
        private readonly DateTime _nextMonthEnd = new DateTime(2013, 03, 31, 23, 59, 59, 999);
        private readonly DateTime _prevMonthStart = new DateTime(2013, 01, 01);
        private readonly DateTime _prevMonthEnd = new DateTime(2013, 01, 31, 23, 59, 59, 999);

        [Test]
        public void should_correctly_calculate_this_month_start()
        {
            var tense = new This();
            var place = new Start();
            var unit = new Month(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_thisMonthStart));
        }

        [Test]
        public void should_correctly_calculate_this_month_end()
        {
            var tense = new This();
            var place = new End();
            var unit = new Month(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_thisMonthEnd));
        }

        [Test]
        public void should_correctly_calculate_next_month_start()
        {
            var tense = new Next();
            var place = new Start();
            var unit = new Month(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_nextMonthStart));
        }

        [Test]
        public void should_correctly_calculate_next_month_end()
        {
            var tense = new Next();
            var place = new End();
            var unit = new Month(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_nextMonthEnd));
        }

        [Test]
        public void should_correctly_calculate_prev_month_start()
        {
            var tense = new Prev();
            var place = new Start();
            var unit = new Month(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_prevMonthStart));
        }

        [Test]
        public void should_correctly_calculate_prev_month_end()
        {
            var tense = new Prev();
            var place = new End();
            var unit = new Month(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_prevMonthEnd));
        }
    }
}