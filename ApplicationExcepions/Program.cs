using System;

namespace ApplicationExcepions
{
    class Program
    {
        static void Main()
        {

            try
            {
                ContaCorrente c = new ContaCorrente();
                c.Depositar(200);
                c.Sacar(250);
            }
            catch (ContaCorrenteException e)
            {
                Console.WriteLine("ERRO");;
            }
        }
    }
}
