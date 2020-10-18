using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace POPCORN.Classes
{
    public class Clock
    {
        public string HourString()
        {
            return DateTime.Now.ToString("hh:");
        }
        public string MinuteString()
        {
            return DateTime.Now.ToString("mm:");
        }
        public string SecondString()
        {
            return DateTime.Now.ToString("ss");
        }
        public string AMPMString()
        {
            return DateTime.Now.ToString(" tt");
        }
    }
}
