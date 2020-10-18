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
        public string Hour { get; set; }
        public string Minute { get; set; }
        public string Second { get; set; }
        public string AmPm { get; set; }

        //public DisplayUI();
        //{}


        public void ClockDisplay()
        {
            Clock clock = new Clock();

            Hour = clock.HourString();
            Minute = clock.MinuteString();
            Second = clock.SecondString();
            AmPm = clock.AMPMString();

            Console.Write(Hour);
            Console.Write(":");
            Console.Write(Minute);
            Console.Write(":");
            Console.Write(Second);
            Console.Write(AmPm);

            while (true)
            {
                if (Hour != clock.HourString())
                {
                    Hour = clock.HourString();
                    Minute = clock.MinuteString();
                    Second = clock.SecondString();

                    if(Hour == "12")
                    {
                        AmPm = clock.AMPMString();
                    }

                    Console.Write("\b\b\b\b\b\b\b\b\b\b");
                    Console.Write(Hour);
                    Console.Write(":");
                    Console.Write(Minute);
                    Console.Write(":");
                    Console.Write(Second);
                    Console.Write(AmPm);
                }
                else if (Minute != clock.MinuteString())
                {
                    Minute = clock.MinuteString();
                    Second = clock.SecondString();

                    Console.Write("\b\b\b\b\b\b\b\b");
                    Console.Write(Minute);
                    Console.Write(":");
                    Console.Write(Second);
                    Console.Write(AmPm);
                }
                else
                {
                    Second = clock.SecondString();

                    Console.Write("\b\b\b\b\b");
                    Console.Write(Second);
                    Console.Write(AmPm);
                }

                Thread.Sleep(1000);
            }
        }
    }
}
