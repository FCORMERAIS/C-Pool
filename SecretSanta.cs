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
            }
            for (int i = 0; i < count/2; i++)
            {
                Console.WriteLine(rnd.Next()%(int)(count/2));
                string a = list[rnd.Next()%(int)(count-i*2)];
                Console.WriteLine(a);
                list.Remove(a);
                string b = list[rnd.Next()%(count-i*2-1)];
                list.Remove(b);
                Console.WriteLine(b);
                dico.Add(a,b);
            }
            return dico;
        }
    }
}