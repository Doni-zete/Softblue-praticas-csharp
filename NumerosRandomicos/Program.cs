using System;

namespace NumerosRandomicos
{
    class Program
    {
        static void Main()
        {
            Random r = new Random(2);
            for (int i = 0; i <10; i++)
            {
                int n = r.Next(0, 10);
                Console.WriteLine(n); 
            }
        }
    }
}
