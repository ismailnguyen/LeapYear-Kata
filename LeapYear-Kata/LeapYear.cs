namespace LeapYear_Kata
{
    public class LeapYear
    {
        public bool IsLeapYeart(int inputYear)
        {
            return isTypicalLeapYear(inputYear)
                && !isAtypicalYear(inputYear)
                || isAtypicalLeapYear(inputYear);
        }

        private bool isTypicalLeapYear(int inputYear)
        {
            return isDisivisblePer(inputYear, 4);
        }

        private bool isAtypicalYear(int inputYear)
        {
            return isDisivisblePer(inputYear, 100);

        }
        private bool isAtypicalLeapYear(int inputYear)
        {
            return isDisivisblePer(inputYear, 100) && isDisivisblePer(inputYear, 400);
        }

        private bool isDisivisblePer(int inputYear, int dividend)
        {
            return inputYear % dividend == 0;
        }
    }
}