using System;
using CSharpDiscovery.Quest02;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tab = new int[5] { 99, 98, 92, 97, 95 };
            var tab2 = new int[] {};
            Console.WriteLine(ContainsThisValue_Exercice.ContainsThisValue(tab, 97));
            Console.WriteLine(ContainsThisValue_Exercice.ContainsThisValue(tab2, 51));
        }
    }
}