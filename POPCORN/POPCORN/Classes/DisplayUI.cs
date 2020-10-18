using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace POPCORN.Classes
{
    public class DisplayUI
    {
        public Dictionary<string, string> Hours { get; private set; } = new Dictionary<string, string>();
        public Dictionary<string, string> Minutes { get; private set; } = new Dictionary<string, string>();
        public Dictionary<string, string> Seconds { get; private set; } = new Dictionary<string, string>();

        public void ClockDisplay()
        {
            Clock clock = new Clock();

            string hour = clock.HourString();
            string minute = clock.MinuteString();
            string second = clock.SecondString();
            string amPm = clock.AMPMString();

            Console.Write(hour);
            Console.Write(minute);
            Console.Write(second);
            Console.Write(amPm);

            while (true)
            {
                if (hour != clock.HourString())
                {
                    hour = clock.HourString();
                    minute = clock.MinuteString();
                    second = clock.SecondString();
                    amPm = clock.AMPMString();

                    Console.Write("\b\b\b\b\b\b\b\b\b\b");
                    Console.Write(hour);
                    Console.Write(minute);
                    Console.Write(second);
                    Console.Write(amPm);
                }
                else if (minute != clock.MinuteString())
                {
                    minute = clock.MinuteString();
                    second = clock.SecondString();
                    amPm = clock.AMPMString();

                    Console.Write("\b\b\b\b\b\b\b\b");
                    Console.Write(minute);
                    Console.Write(second);
                    Console.Write(amPm);
                }
                else
                {
                    Console.Write("\b\b\b\b\b");
                    Console.Write(clock.SecondString());
                    Console.Write(clock.AMPMString());
                }

                Thread.Sleep(1000);
            }
        }
    }
}
