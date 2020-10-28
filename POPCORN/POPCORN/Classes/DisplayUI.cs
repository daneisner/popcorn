using System;
using System.Collections.Generic;
using System.Threading;

namespace POPCORN.Classes
{
    public class DisplayUI
    {
        public Dictionary<string, string> Hours { get; private set; } = new Dictionary<string, string>();
        public Dictionary<string, string> Minutes { get; private set; } = new Dictionary<string, string>();
        public Dictionary<string, string> Seconds { get; private set; } = new Dictionary<string, string>();
        public Clock Clock { get; } = new Clock();
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


            Hour = Clock.GetHour();
            Minute = Clock.GetMinute();
            Second = Clock.GetSecond();
            AmPm = Clock.GetAMPM();
        }


        public void ClockDisplay()
        {
            



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

                //Hour = clock.GetHour();
                //Minute = clock.GetMinute();
                //Second = clock.GetSecond();

                if (Hour == "12")
                {
                    AmPm = Clock.GetAMPM();
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
            int cursorFromLeft = 0;
            int cursorFromTop = 1;

            for (int i = 0; i < 120; i++)
            {
                try
                {
                    if (int.Parse(Second) % 10 == 0)
                    {


                        Console.SetCursorPosition(cursorFromLeft, cursorFromTop);

                        cursorFromLeft = WriteInTheRightSpot("At ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot("the ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot("tone ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot($"{CurrentTimeZone} ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot("will ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot("be ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot($"{Hours[Hour]} ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot($"{Minutes[Minute]} ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot($"{Seconds[Second]}.....", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot("\aBeep\n", cursorFromLeft, cursorFromTop);
                        Console.Beep();

                        cursorFromLeft = 0;
                        cursorFromTop += 1;

                        //Console.Clear();
                        //Console.WriteLine();

                        //Console.Write("At ");
                        //Thread.Sleep(1000);
                        //Console.Write("the ");
                        //Thread.Sleep(1000);
                        //Console.Write("tone ");
                        //Thread.Sleep(1000);
                        //Console.Write($"{CurrentTimeZone} ");
                        //Thread.Sleep(1000);
                        //Console.Write("will ");
                        //Thread.Sleep(1000);
                        //Console.Write("be ");
                        //Thread.Sleep(1000);
                        //Console.Write($"{Hours[Hour]} ");
                        //Thread.Sleep(1000);
                        //Console.Write($"{Minutes[Minute]} ");
                        //Thread.Sleep(1000);
                        //Console.Write($"{Seconds[Second]}.....");
                        //Thread.Sleep(1000);
                        //Console.Write("Beep!");
                        //Console.Beep();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something happened {i}");
                }
                Thread.Sleep(1000);



                //Console.Beep();

            }

        }

        private int WriteInTheRightSpot(string popcornText, int cursorFromLeft, int cursorFromTop)
        {
            Console.SetCursorPosition(cursorFromLeft, cursorFromTop);
            Console.Write(popcornText);
            cursorFromLeft = Console.CursorLeft;
            Thread.Sleep(750);
            return cursorFromLeft;
        }

    }
}
