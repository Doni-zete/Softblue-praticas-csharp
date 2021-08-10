using System;


namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            string s2 = "abc";

            Console.WriteLine(s1.Equals(s2));
            int i1 = 10;
            int i2 = 10;
            Console.WriteLine(i1.Equals(i2));

            Aluno a1 = new Aluno("Pedro");
            Aluno a2 = new Aluno("Pedro");
            Console.WriteLine(a1.Equals(a2));

        }
    }
}
public class Aluno
{
    public string Nome { get; set; }
    public Aluno (string nome)
    {
        this.Nome = nome;
    }
}
