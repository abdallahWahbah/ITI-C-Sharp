using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_lab
{
    internal class Duration
    {
        int hours;
        int minutes;
        int seconds;

        public Duration() { hours = minutes = seconds = 0; }
        public Duration(int _hours,  int _minutes, int _seconds)
        {
            // 3:70:65 >> 4:11:5
            _minutes += _seconds / 60;
            _seconds = _seconds % 60;

            _hours += _minutes / 60;
            _minutes = _minutes % 60;

            hours = _hours;
            minutes = _minutes;
            seconds = _seconds;
        }
        public Duration(int totalSeconds)
        {
            // 3700 >> 1:1:40
            int _hours = totalSeconds / 3600;
            int remainingSeconds = totalSeconds % 3600;
            int _minutes = remainingSeconds / 60;
            int _seconds = remainingSeconds % 60;

            hours = _hours;
            minutes = _minutes;
            seconds = _seconds;
        }
        // property overloading
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.hours + d2.hours, d1.minutes + d2.minutes, d1.seconds + d2.seconds);
        }
        // int + Duration
        public static Duration operator +(int _seconds, Duration d)
        {
            return new Duration(d.hours, d.minutes, d.seconds + _seconds);
        }
        // Duration + int
        public static Duration operator +(Duration d, int _seconds)
        {
            return new Duration(d.hours, d.minutes, d.seconds + _seconds);
        }
        // ++ 
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.hours, d.minutes + 1, d.seconds);
        }


        public override string ToString()
        {
            return $"{hours}:{minutes}:{seconds}";
        }
    }
}
