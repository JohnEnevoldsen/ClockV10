using System;

namespace ClockV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Clock myBigWhiteClock = new Clock();
            myBigWhiteClock.DisplayTime();
            myBigWhiteClock.SetTime(23, 59);
            myBigWhiteClock.DisplayTime();
            myBigWhiteClock.AdvanceTimeByOneMinute();
            myBigWhiteClock.DisplayTime();
            // The LAST line of code should be ABOVE this line
        }
    }
}