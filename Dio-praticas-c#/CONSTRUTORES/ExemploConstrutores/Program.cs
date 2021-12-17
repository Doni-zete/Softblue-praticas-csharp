using System;
using ExemploConstrutores.models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data =new Data();
            data.Setmes(2);
            data.ApresentarMes();
            // Log log = Log.GetInstance();

            // log.propriedadeLog ="Teste instancia";

            // Log log2 = Log.GetInstance() ;
            // System.Console.WriteLine(log2.propriedadeLog);
            // Aluno  p1 = new Aluno("Teste", "bruta", "ciencia");
            // p1.Apresentar();
        }
    }
}
