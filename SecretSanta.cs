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
            int count = 0;
            foreach (var item in list)
            {
                count= count+1;
                Console.WriteLine(item);
            }
            for (int i = 0; i < count/2; i++)
            {
                string a = list[rnd.Next()%(int)(count-i*2)];
                list.Remove(a);
                string b = list[rnd.Next()%(count-i*2-1)];
                list.Remove(b);
                dico.Add(a,b);
            }
            return dico;
        }
    }
}