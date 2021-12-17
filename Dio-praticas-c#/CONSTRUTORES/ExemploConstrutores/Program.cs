using System;
using ExemploConstrutores.models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao (int x, int y);
        static void Main(string[] args)

        {
            // Operacao op Calculadora.Somar;
            Operacao op = new Operacao(Calculadora.Somar);
            op.Invoke(10,10);

            // const double pi =3.14;

            // System.Console.WriteLine(pi);
           
            // Data data =new Data();
            // // data.Setmes(20);

            // data.Mes =20;
            // System.Console.WriteLine(data.Mes);
            // data.ApresentarMes();
            // Log log = Log.GetInstance();

            // log.propriedadeLog ="Teste instancia";

            // Log log2 = Log.GetInstance() ;
            // System.Console.WriteLine(log2.propriedadeLog);
            // Aluno  p1 = new Aluno("Teste", "bruta", "ciencia");
            // p1.Apresentar();
        }
    }
}
