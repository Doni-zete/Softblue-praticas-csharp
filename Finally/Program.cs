using System;

namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Executar(true);
                
            }

            catch (ArgumentException e)
            {
                Console.WriteLine("Exceção tratada");
            }
            finally
            {
                Console.WriteLine("Aplicação terminada");
            }


        }
        static void Executar(bool b)
        {
            if (b)
            {
                throw new ArgumentException();
            }
        }
    }
}
