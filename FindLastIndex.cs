namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
            int res = 0;
            for(int i = 0; i < tab.Length; i++)
            {
                if(tab[i] == a) 
                {
                    res = i;
                }
            }
            if (res == 0) {return null;}
            return res;
        }
    }
}