using System;

namespace CSharpDiscovery.Quest02
{
    public class TodayAtMidnight_Exercice
    {
        public static DateTime TodayAtMidnight()
        {
            DateTime s = DateTime.Now;
            TimeSpan ts = new TimeSpan(0, 0, 0);
            return s.Date+ts;
        }
    }
}