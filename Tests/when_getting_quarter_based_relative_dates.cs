using System;
using DateRange.Places;
using DateRange.Tenses;
using DateRange.Units;
using NUnit.Framework;

namespace DateRange.Tests
{
    [TestFixture]
    public class when_getting_quarter_based_relative_dates
    {
        private readonly DateTime _dateTime = new DateTime(2013, 02, 27, 12, 22, 54, 154);
        
        private readonly DateTime _thisQuarterStart = new DateTime(2013, 01, 01);
        private readonly DateTime _thisQuarterEnd = new DateTime(2013, 03, 31, 23, 59, 59, 999);
        private readonly DateTime _nextQuarterStart = new DateTime(2013, 04, 01);
        private readonly DateTime _nextQuarterEnd = new DateTime(2013, 06, 30, 23, 59, 59, 999);
        private readonly DateTime _prevQuarterStart = new DateTime(2012, 10, 01);
        private readonly DateTime _prevQuarterEnd = new DateTime(2012, 12, 31, 23, 59, 59, 999);

        [Test]
        public void should_correctly_calculate_this_quarter_start()
        {
            var tense = new This();
            var place = new Start();
            var unit = new Quarter(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_thisQuarterStart));
        }

        [Test]
        public void should_correctly_calculate_this_quarter_end()
        {
            var tense = new This();
            var place = new End();
            var unit = new Quarter(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_thisQuarterEnd));
        }

        [Test]
        public void should_correctly_calculate_next_quarter_start()
        {
            var tense = new Next();
            var place = new Start();
            var unit = new Quarter(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_nextQuarterStart));
        }

        [Test]
        public void should_correctly_calculate_next_quarter_end()
        {
            var tense = new Next();
            var place = new End();
            var unit = new Quarter(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_nextQuarterEnd));
        }

        [Test]
        public void should_correctly_calculate_prev_quarter_start()
        {
            var tense = new Prev();
            var place = new Start();
            var unit = new Quarter(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_prevQuarterStart));
        }

        [Test]
        public void should_correctly_calculate_prev_quarter_end()
        {
            var tense = new Prev();
            var place = new End();
            var unit = new Quarter(_dateTime);
            var dt = unit.GetDateTime(tense, place);
            Assert.That(dt, Is.EqualTo(_prevQuarterEnd));
        }
    }
}