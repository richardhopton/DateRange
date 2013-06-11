using System;
using DateRange.Places;
using DateRange.Tenses;
using DateRange.Units;
using NUnit.Framework;

namespace DateRange.Tests
{
    [TestFixture]
    public class when_getting_year_based_relative_dates
    {
        private readonly DateTime _dateTime = new DateTime(2013, 02, 27, 12, 22, 54, 154);
        
        private readonly DateTime _thisYearStart = new DateTime(2013, 01, 01);
        private readonly DateTime _thisYearEnd = new DateTime(2013, 12, 31, 23, 59, 59, 999);
        private readonly DateTime _nextYearStart = new DateTime(2014, 01, 01);
        private readonly DateTime _nextYearEnd = new DateTime(2014, 12, 31, 23, 59, 59, 999);
        private readonly DateTime _prevYearStart = new DateTime(2012, 01, 01);
        private readonly DateTime _prevYearEnd = new DateTime(2012, 12, 31, 23, 59, 59, 999);

        [Test]
        public void should_correctly_calculate_this_year_start()
        {
            var tense = new This();
            var place = new Start();
            var unit = new Year(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_thisYearStart));
        }

        [Test]
        public void should_correctly_calculate_this_year_end()
        {
            var tense = new This();
            var place = new End();
            var unit = new Year(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_thisYearEnd));
        }

        [Test]
        public void should_correctly_calculate_next_year_start()
        {
            var tense = new Next();
            var place = new Start();
            var unit = new Year(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_nextYearStart));
        }

        [Test]
        public void should_correctly_calculate_next_year_end()
        {
            var tense = new Next();
            var place = new End();
            var unit = new Year(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_nextYearEnd));
        }

        [Test]
        public void should_correctly_calculate_prev_year_start()
        {
            var tense = new Prev();
            var place = new Start();
            var unit = new Year(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_prevYearStart));
        }

        [Test]
        public void should_correctly_calculate_prev_year_end()
        {
            var tense = new Prev();
            var place = new End();
            var unit = new Year(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_prevYearEnd));
        }
    }
}