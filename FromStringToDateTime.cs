using System;
namespace CSharpDiscovery.Quest02
{
    public class FromStringToDateTime_Exercice
    {
        public static DateTime FromStringToDateTime(string dateStr)
        {
            DateTime res = DateTime.Parse(dateStr);
            return res;
        }
    }
}