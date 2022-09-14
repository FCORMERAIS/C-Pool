using System;

namespace CSharpDiscovery.Quest02
{
    public class SortTable_Exercice
    {
        public static int[] SortTable(int[] Tableau)
        {
            if (Tableau == null)
            {
                return null;
            }
            Array.Sort(Tableau);
            return Tableau;
        }
    }
}