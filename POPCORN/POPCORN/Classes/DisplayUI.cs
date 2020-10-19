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
        public string Hour { get; private set; }
        public string Minute { get; private set; }
        public string Second { get; private set; }
        public string AmPm { get; private set; }
        private TimeZoneInfo TimeZone { get; set; } = TimeZoneInfo.Local;
        public string CurrentTimeZone { get; set; }

        public DisplayUI()
        {
            Hours = FileIO.ReadTime("hours.csv");
            Minutes = FileIO.ReadTime("minutes.csv");
            Seconds = FileIO.ReadTime("seconds.csv");

            CurrentTimeZone = TimeZone.ToString();
        }


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
                    Console.SetCursorPosition(0, 0);

                    Hour = clock.HourString();
                    Minute = clock.MinuteString();
                    Second = clock.SecondString();

                    if (Hour == "12")
                    {
                        AmPm = clock.AMPMString();
                    }

                    Console.Write(Hour);
                    Console.Write(":");
                    Console.Write(Minute);
                    Console.Write(":");
                    Console.Write(Second);
                    Console.Write(AmPm);
                }
                else if (Minute != clock.MinuteString())
                {
                    Console.SetCursorPosition(3, 0);

                    Minute = clock.MinuteString();
                    Second = clock.SecondString();

                    Console.Write(Minute);
                    Console.Write(":");
                    Console.Write(Second);
                    Console.Write(AmPm);
                }
                else
                {
                    Console.SetCursorPosition(6, 0);

                    Second = clock.SecondString();

                    Console.Write(Second);
                    Console.Write(AmPm);
                }

                Thread.Sleep(1000);
            }
        }

        public void CallPopcorn()
        {
            while (true)
            {
                Console.Beep();
                
            }
            
        }
       
    }
}
