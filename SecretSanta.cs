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
                dico.Add(list[rnd.Next()%(int)(count/2)], list[rnd.Next()%(int)(count/2)]);
            }
            return dico;
        }
    }
}