using System;

namespace ClockV10
{
    public class Clock
    {
        private int _timeInMinutesSince0000;

        public int CurrentTimeInMinutes{
            get{return _timeInMinutesSince0000%60;}
        }

        public int CurrentTimeInHours{
            get{return _timeInMinutesSince0000%1440/60;}
        }
        public void SetTime(int hours, int minutes){
            _timeInMinutesSince0000 = 60 *hours + minutes;
        }
        public void DisplayTime(){
            Console.WriteLine($"The clock is pointing at {CurrentTimeInHours:D2}:{CurrentTimeInMinutes:D2}");
        }

        public void AdvanceTimeByOneMinute(){
            _timeInMinutesSince0000++;
        }
    }
}