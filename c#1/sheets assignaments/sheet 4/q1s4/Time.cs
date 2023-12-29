using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1s4
{
    internal class Time
    {
            private int hours;
            private int minutes;
            private int seconds;

            public Time()
            {
                hours = 0;
                minutes = 0;
                seconds = 0;
            }
            public Time(int hours, int minutes, int seconds)
            {
                this.hours = hours;
                this.minutes = minutes;
                this.seconds = seconds;
            }

            public void PrintTime24Hours()
            {
                Console.WriteLine($"{hours:D2}:{minutes:D2}:{seconds:D2}");
            }
         public void PrintTime12Hours()
            {
            int displayHours;

            if (hours % 12 == 0)
            {
                displayHours = 12;
            }
            else
            {
                displayHours = hours % 12;
            }
            string period = hours < 12 ? "AM" : "PM";
                Console.WriteLine($"{displayHours:D2}:{minutes:D2}:{seconds:D2} {period}");
            }
    }
}
