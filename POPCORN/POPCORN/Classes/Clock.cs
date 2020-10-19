using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace POPCORN.Classes
{
    public class Clock
    {
        public string GetHour()
        {
            return DateTime.Now.ToString("hh");
        }
        public string GetMinute()
        {
            return DateTime.Now.ToString("mm");
        }
        public string GetSecond()
        {
            return DateTime.Now.ToString("ss");
        }
        public string GetAMPM()
        {
            return DateTime.Now.ToString(" tt");
        }
    }
}
