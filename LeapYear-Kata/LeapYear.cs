namespace LeapYear_Kata
{
    public class LeapYear
    {
        public bool IsLeapYeart(int inputYear)
        {
            return isDisivisblePer(inputYear, 4)
                && !isDisivisblePer(inputYear, 100)
                || (isDisivisblePer(inputYear, 100) && isDisivisblePer(inputYear, 400));
        }

        private bool isDisivisblePer(int inputYear, int dividend)
        {
            return inputYear % dividend == 0;
        }
    }
}