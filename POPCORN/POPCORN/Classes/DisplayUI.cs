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

            Hour = clock.GetHour();
            Minute = clock.GetMinute();
            Second = clock.GetSecond();
            AmPm = clock.GetAMPM();



            Console.Write(Hour);
            Console.Write(":");
            Console.Write(Minute);
            Console.Write(":");
            Console.Write(Second);
            Console.Write(AmPm);

            for (int i = 0; i < 120; i++)
            {
                //if (Hour != clock.GetHour())
                //{
                    Console.SetCursorPosition(0, 0);

                    Hour = clock.GetHour();
                    Minute = clock.GetMinute();
                    Second = clock.GetSecond();

                    if (Hour == "12")
                    {
                        AmPm = clock.GetAMPM();
                    }

                    Console.Write(Hour);
                    Console.Write(":");
                    Console.Write(Minute);
                    Console.Write(":");
                    Console.Write(Second);
                    Console.Write(AmPm);
                //}
                //else if (Minute != clock.GetMinute())
                //{
                //    Console.SetCursorPosition(3, 0);

                //    Minute = clock.GetMinute();
                //    Second = clock.GetSecond();

                //    Console.Write(Minute);
                //    Console.Write(":");
                //    Console.Write(Second);
                //    Console.Write(AmPm);
                //}
                //else
                //{
                //    Console.SetCursorPosition(6, 0);

                //    Second = clock.GetSecond();

                //    Console.Write(Second);
                //    Console.Write(AmPm);
                //}

                Thread.Sleep(1000);
            }
        }

        public void CallPopcorn()
        {
            for (int i = 0; i < 120; i++)
            {
                try
                {
                    if (int.Parse(Second) % 10 == 0)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.Write("At ");
                        Console.Write("the ");
                        Console.Write("tone ");
                        Console.Write($"{CurrentTimeZone} ");
                        Console.Write("will ");
                        Console.Write("be ");
                        Console.Write($"{Hours[Hour]} ");
                        Console.Write($"{Minutes[Minute]} ");
                        Console.Write($"{Seconds[Second]}.....");
                        Console.Write("\aBeep!");
                    }
                }
                catch (Exception e)
                { }
                Thread.Sleep(1000);
                


                //Console.Beep();

            }

        }

    }
}
