using System;
using System.Threading;
using Humanizer;
using POPCORN.Classes;
using TimeZoneConverter;

namespace POPCORN
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DisplayUI display = new DisplayUI();
                ThreadStart clockThread = new ThreadStart(display.ClockDisplay);
                Thread clock = new Thread(new ThreadStart(display.ClockDisplay));
                clock.Start();

                Thread popcorn = new Thread(new ThreadStart(display.CallPopcorn));
                popcorn.Start();
            }
            catch
            {
                Console.WriteLine("Exception!!!");
            }
        }
    }
}
