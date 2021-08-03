using System;

namespace Objctinitializer.Contato
{
    class Program
    {
        static void Main()
        {
            Contato c = new Contato();
            c.Nome = "jose Silva";
            c.Telefone = "7837-2974";
            c.Email = "jose@gmail.com";
            c.Endereco = "R. dos limões, 320";
            c.MostrarInfo();
        }
    }

    public class Contato
    {
        public string Nome { get; set; }
        public string telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }


        public Contato()
        {
            Console.WriteLine("Contato()");
        }

        public Contato(string nome)
        {
            Console.Write("Contato(string)");
            this.Nome = nome;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Telefone: " + Telefone);
            Console.WriteLine("Email: " + Email);


        }
    }

}
