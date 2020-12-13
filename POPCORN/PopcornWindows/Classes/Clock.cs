using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
//using TimeZoneConverter;

namespace POPCORN.Classes
{
    public class Clock
    {
        public string StringHour
        {
            get
            {
                return DateTime.Now.ToString("hh");
            }
        }

        public int IntHour
        {
            get
            {
                return int.Parse(StringHour);
            }
        }

        public string StringMinute
        {
            get
            {
                return DateTime.Now.ToString("mm");
            }
        }

        public int IntMinute
        {
            get
            {
                return int.Parse(StringMinute);
            }
        }

        public string StringSecond
        {
            get
            {
                return DateTime.Now.ToString("ss");
            }
        }

        public int IntSecond
        {
            get
            {
                return int.Parse(StringSecond);
            }
        }

        public string GetAMPM()
        {
            return DateTime.Now.ToString(" tt");
        }

        private TimeZoneInfo TimeZone
        {
            get
            {
                return TimeZoneInfo.Local;
            }
        }

        public string CurrentTimeZone
        {
            get
            {
                if (TimeZone.IsDaylightSavingTime(DateTime.Now))
                {
                    return TimeZone.DaylightName;
                }
                else
                {
                    return TimeZone.Id;
                }
            }
        }
    }
}
