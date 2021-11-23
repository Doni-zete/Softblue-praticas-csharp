using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FilasPilhas
{
    class Program
    {

        static void Main(string[] args)
        {
            Queue<char> queue = new Queue<char>();
            while (true)
            {
                Console.WriteLine("Elemento: ");
                string s;
                if (String.IsNullOrWhiteSpace(s))
                {
                    break;
                }
                char c = s[0];
                queue.Enqueue(c);
            }
            while (true)
            {
                char c = queue.Dequeue();
                Console.WriteLine("=> "+c);
                if (queue.Count == 0)
                {
                    break;
                }
            }
        }
    }
}