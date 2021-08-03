using System;

namespace Estrutura.Ponto
{
    class Program
    {
        static void Main()
        {
            Ponto p;
            p.x = 10;
            p.y = 20;
            p.MostrarCoordendas();

        }
    }
    struct Ponto
    {
        public int x;
        public int y;
        public void MostrarCoordendas()
        {
            Console.WriteLine("x=" + x + ",y" + y);
                
        }
    }
}
