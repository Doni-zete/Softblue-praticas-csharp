using System;

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                object o = null;
                o.ToString();

                double r = Matematica.Dividir(10, 0);
                Console.WriteLine(r);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
            catch (Exception )
            {
                Console.WriteLine("Referência null");
            }

            Console.WriteLine("Fim da aplicação");


        }
        public class Matematica
        {
            public static double Dividir(double n, double d)
            {
                if (d == 0)
                {
                    throw new ArgumentException("O denominador não pode ser zero");
                }

                return n / d;
            }
        }
    }
}

