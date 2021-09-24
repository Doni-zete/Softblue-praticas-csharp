using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> dias = new HashSet<string>();
            
            dias.Add("Segunda");
            dias.Add("Terça");
            dias.Add("Quarta");
            dias.Add("Quinta");
            dias.Add("Sexta");
            dias.Remove("Terça");

            foreach(String dia in dias)
            {
                Console.WriteLine(dia); ;
            }

        }
    }
}
