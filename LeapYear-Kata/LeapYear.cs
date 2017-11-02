namespace LeapYear_Kata
{
    public class LeapYear
    {
        public bool IsLeapYear(int inputYear)
        {
            return isTypicalLeapYear(inputYear)
                && !isAtypicalYear(inputYear)
                || isAtypicalLeapYear(inputYear);
        }

        private bool isTypicalLeapYear(int inputYear)
        {
            return isDivisiblePer(inputYear, 4);
        }

        private bool isAtypicalYear(int inputYear)
        {
            return isDivisiblePer(inputYear, 100);
        }

        private bool isAtypicalLeapYear(int inputYear)
        {
            return isDivisiblePer(inputYear, 400);
        }

        private bool isDivisiblePer(int inputYear, int dividend)
        {
            return inputYear % dividend == 0;
        }
    }
}