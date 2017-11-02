using NFluent;
using NUnit.Framework;

namespace LeapYear_Kata.Tests
{
    public class LeapYearTest
    {
        private LeapYear leapYear = new LeapYear();

        [TestCase(2001)]
        [TestCase(1900)]
        public void Shoul_False_When_Given_Year_Is_Not_Leap_Year(int inputYear)
        {
            // WHEN
            bool isLeapYear = leapYear.IsLeapYear(inputYear);

            // THEN
            Check.That(isLeapYear).IsFalse();
        }

        [TestCase(1996)]
        [TestCase(2000)]
        public void Shoul_Return_True_When_Given_Year_Is_Leap_Year(int inputYear)
        {
            // WHEN
            bool isLeapYear = leapYear.IsLeapYear(inputYear);

            // THEN
            Check.That(isLeapYear).IsTrue();
        }
    }
}
