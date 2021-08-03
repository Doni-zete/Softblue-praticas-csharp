using System;

namespace Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string cidade = "Manaus";
            string estado = "Amazonas";

            Console.WriteLine("Cidade:" + cidade + ",Esatdo:" + estado);
            Console.WriteLine("Ciadade: {0}, Estado:{1}", cidade, estado);


            Console.WriteLine("valor:{0,20:C}", 2534.30);
            //Console.WriteLine("Quantidade:{0,20:D5}", 35);
            //Console.WriteLine("Peso: {0,20:N2}",55.342);

            //Console.WriteLine("{0:0000000000}", 345);
            //Console.WriteLine("{0:(##) ####-####}", 1165437865);

            //string s=  string.Format("{0:(##) ####-####}", 1165437865);
            // Console.WriteLine(s);
        }
    }
}
