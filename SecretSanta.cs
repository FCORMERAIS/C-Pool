using System.Linq;
using System;

namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string,string> SecretSantaDraw(HashSet<string> people)
        {
            Random rnd = new Random();
            Dictionary<string, string> dico = new Dictionary<string, string>();
            List<int> list = new List<int>(people);
            Console.WriteLine(list);
            for (int i = 0; i < list.Length/2; i++)
            {
                dico.Add(list[rnd.Next()%(int)(list.Length/2)], list[rnd.Next()%(int)(list.Length/2)]);
            }
            return dico;
        }
    }
}