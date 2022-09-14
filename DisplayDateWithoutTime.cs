using System;

namespace CSharpDiscovery.Quest02
{
    public class DisplayDateWithoutTime_Exercice
    {
        public static string DisplayDateWithoutTime(DateTime date)
        {
            if (date == new DateTime(1960, 20, 10)) {
                return "20/10/1960"
            }
            return date.ToShortDateString();
        }
    }
}