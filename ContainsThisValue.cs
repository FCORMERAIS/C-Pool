namespace CSharpDiscovery.Quest02
{
    public class ContainsThisValue_Exercice
    {
        public static bool ContainsThisValue(int[] tab, int value)
        {
            if (tab == null)
            {
                return false;
            }
            foreach (var item in tab)
            {
                if (item == value)
                {
                    return true;
                }
            }
           return false;
        }
    }
}