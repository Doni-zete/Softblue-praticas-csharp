using System;
using Exemplos.Models;
using EXEMPLOS.Interface;

namespace Exemplos
{
  class Program
  {
    static void Main(string[] args)
    {

ICalculadora calc = new Calculadora();
System.Console.WriteLine(calc.Dividir(10,2));



      // Computador comp = new Computador();
      // System.Console.WriteLine(comp.ToString());
      // Corrente c= new Corrente();
      // c.Creditar(100);
      // c.ExibirSaldo();

      // Calculadora calc = new Calculadora();
      // System.Console.WriteLine("Resultado da primeira soma: "+ calc.Somar(10,10));
      // System.Console.WriteLine("Resultado da primeira subtração: "+ calc.subtrair(20,10,5));


      //   professor p1 =new professor();

      // p1.Nome ="Bob";
      // p1.Idade =20;
      // p1.Documento="123456";
      // p1.Nota =10;
      // p1.Apresentar();




      //Valores validos
      // Retangulo r = new Retangulo();
      // r.DefinirMedidas(30,30) ;
      // System.Console.WriteLine ($"Area:{r.ObterArea()}");

      // Pessoas p1 =new Pessoas();
      // p1.Nome ="Bob";
      // p1.Idade =20;
      // p1.sexo ="Masculino";
      // p1.Apresentar();
    }
  }
}