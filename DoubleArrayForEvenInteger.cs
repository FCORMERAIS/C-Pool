using System;
namespace CSharpDiscovery.Quest01
{
    public class DoubleArrayForEvenInteger_Exercice
    {
         public static int[] DoubleArrayForEvenInteger(int[] inputTab)
        {
            for (int i = 0; i < inputTab.Length; i++)
            {
                if (inputTab[i]%2 == 1) {
                    inputTab[i] = inputTab[i]*2;
                }
            }
            return inputTab;
        }
    }
}