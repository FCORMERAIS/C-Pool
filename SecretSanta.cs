using System;
using System.Collections.Generic;

namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string,string> SecretSantaDraw(HashSet<string> people)
        {
            Random rnd = new Random();
            Dictionary<string, string> dico = new Dictionary<string, string>();
            List<string> list = new List<string>(people);
            List<string> list2 = new List<string>(people);
            int count = 0;
            foreach (var item in list)
            {
                count= count+1;
            }
            for (int i = 0; i < count; i++)
            {
                string a = list[rnd.Next()%(count-i)];
                Console.WriteLine(i);
                Console.WriteLine(a);
                list.Remove(a);
                string b = list2[rnd.Next()%(count)];
                while (b==a)
                {
                    b = list2[rnd.Next()%(count)];
                }
                dico.Add(a,b);
            }
            return dico;
        }
    }
}