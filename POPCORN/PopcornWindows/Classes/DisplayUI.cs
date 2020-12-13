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
        public string StringHour { get; private set; }
        public string StringMinute { get; private set; }
        public string StringSecond { get; private set; }
        public string AmPm { get; private set; }

        public DisplayUI()
        {
            Hours = FileIO.ReadTime("hours.csv");
            Minutes = FileIO.ReadTime("minutes.csv");
            Seconds = FileIO.ReadTime("seconds.csv");

            StringHour = Clock.StringHour;
            StringMinute = Clock.StringMinute;
            StringSecond = Clock.StringSecond;
            AmPm = Clock.GetAMPM();
        }


        public void ClockDisplay()
        {
            Console.Write(StringHour);
            Console.Write(":");
            Console.Write(StringMinute);
            Console.Write(":");
            Console.Write(StringSecond);
            Console.Write(AmPm);

            for (int i = 0; i < 120; i++)
            {
                Console.SetCursorPosition(0, 0);

                StringHour = Clock.StringHour;
                StringMinute = Clock.StringMinute;
                StringSecond = Clock.StringSecond;

                if (StringHour == "12")
                {
                    AmPm = Clock.GetAMPM();
                }

                Console.Write(StringHour);
                Console.Write(":");
                Console.Write(StringMinute);
                Console.Write(":");
                Console.Write(StringSecond);
                Console.Write(AmPm);

                Thread.Sleep(1000);
            }
        }

        public void CallPopcorn()
        {
            int cursorFromLeft = 0;
            int cursorFromTop = 1;

            string popcornSecond = StringSecond;
            string popcornMinute = StringMinute;
            string popcornHour = StringHour;

            for (int i = 0; i < 120; i++)
            {
                if (Clock.IntSecond >= 0 && Clock.IntSecond < 10)
                {
                    popcornSecond = "10";
                }
                else if (Clock.IntSecond >= 10 && Clock.IntSecond < 20)
                {
                    popcornSecond = "20";
                }
                else if (Clock.IntSecond >= 20 && Clock.IntSecond < 30)
                {
                    popcornSecond = "30";
                }
                else if (Clock.IntSecond >= 30 && Clock.IntSecond < 40)
                {
                    popcornSecond = "40";
                }
                else if (Clock.IntSecond >= 40 && Clock.IntSecond < 50)
                {
                    popcornSecond = "50";
                }
                else if (Clock.IntSecond >= 50 && Clock.IntSecond < 60)
                {
                    popcornSecond = "00";
                    if (Clock.IntMinute == 59)
                    {
                        if (Clock.IntHour + 1 < 10)
                        {
                            popcornHour = "0" + (Clock.IntHour + 1).ToString(); 
                        }
                        else
                        {
                            popcornHour = (Clock.IntHour + 1).ToString();
                        }
                    }
                    if (Clock.IntMinute > 8)
                    {
                        popcornMinute = Clock.IntMinute < 59 ? (Clock.IntMinute + 1).ToString() : "00"; 
                    }
                    else
                    {
                        popcornMinute = "0" + (Clock.IntMinute + 1).ToString();
                    }
                }

                try
                {
                    if (Clock.IntSecond % 10 == 0)
                    {
                        cursorFromLeft = WriteInTheRightSpot("\aBeep\n", cursorFromLeft, cursorFromTop);
                        Console.Beep();

                        cursorFromLeft = 0;
                        cursorFromTop += 1;

                        Console.SetCursorPosition(cursorFromLeft, cursorFromTop);

                        cursorFromLeft = WriteInTheRightSpot("At ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot("the ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot("tone ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot($"{Clock.CurrentTimeZone} ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot("will ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot("be ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot($"{Hours[popcornHour]} ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot($"{Minutes[popcornMinute]} ", cursorFromLeft, cursorFromTop);
                        cursorFromLeft = WriteInTheRightSpot($"{Seconds[popcornSecond]}.....", cursorFromLeft, cursorFromTop);
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine($"Something happened {i}");
                    Console.WriteLine(e.Message);
                }
                Thread.Sleep(1000);
            }

        }

        private int WriteInTheRightSpot(string popcornText, int cursorFromLeft, int cursorFromTop)
        {
            Console.SetCursorPosition(cursorFromLeft, cursorFromTop);
            Console.Write(popcornText);
            cursorFromLeft = Console.CursorLeft;
            Thread.Sleep(850);
            return cursorFromLeft;
        }
    }
}
