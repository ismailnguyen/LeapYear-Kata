using NFluent;
using NUnit.Framework;

namespace LeapYear_Kata.Tests
{
    public class LeapYearTest
    {
        /*
            LEAP YEAR
            Une méthode qui retourne vrai ou faux selon que l’entier en argument est une année bissextile ou non.
            Une année bissextile est divisible par 4, mais n’est pas divisible par 100 à moins qu’elle soit aussi divisible par 400.
            2001 est une année normale typique
            1996 est une année bissextile typique
            1900 est une année normale atypique
            2000 est une année bissextile atypique
        */

        private LeapYear leapYear;

        [SetUp]
        public void Setup()
        {
            leapYear = new LeapYear();
        }

        [Test]
        public void Shoul_False_True_When_Given_Year_Is_2001()
        {
            // GIVEN
            int inputYear = 2001;

            // WHEN
            bool isLeapYear = leapYear.IsLeapYeart(inputYear);

            // THEN
            Check.That(isLeapYear).IsFalse();
        }

        [Test]
        public void Shoul_Return_True_When_Given_Year_Is_1996()
        {
            // GIVEN
            int inputYear = 1996;

            // WHEN
            bool isLeapYear = leapYear.IsLeapYeart(inputYear);

            // THEN
            Check.That(isLeapYear).IsTrue();
        }
    }
}
