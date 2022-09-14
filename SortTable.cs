using System;

namespace CSharpDiscovery.Quest02
{
    public class SortTable_Exercice
    {
        public static int[] SortTable(int[] Tableau)
        {
            for(int I = 1000 - 2;I >= 0; I--) {
                for(int J = 0; J <= I; J++) {
                    if(Tableau[J + 1] < Tableau[J]) {
                        int t = Tableau[J + 1];
                        Tableau[J + 1] = Tableau[J];
                        Tableau[J] = t;
                    }
                }
            }
            return Tableau;
        }
    }
}