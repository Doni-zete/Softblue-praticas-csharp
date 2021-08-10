using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main()
        {
            List<string> nomes = new List<string>();
            nomes.Add("José");
            nomes.Add("Maria");
            nomes.Add("Pedro");
            nomes.Insert(1, "Paula");


            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            for (int i = 0; i < nomes.Count; i++)
            {
                string nome = nomes[i];
                Console.WriteLine(nome);
            }

            bool b = nomes.Contains("José");
            Console.WriteLine(b);
        }
    }
}
