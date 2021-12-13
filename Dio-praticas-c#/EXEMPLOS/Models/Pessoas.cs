using System;

namespace Exemplos
{
    public class Pessoas
    {
        public string Nome{get; set;}
        public int Idade{get;set;}
        public string sexo{get;set;}
        public void Apresentar(){
            Console.WriteLine($"Meu nome é: {Nome} tenho {Idade}anos e meu sexo e {sexo}");
        }
    }
}