using System;
using System.Collections.Generic;
using System.IO;
using Exemplos.Models;
using EXEMPLOS.helper;
using EXEMPLOS.Interface;

namespace Exemplos
{
  class Program
  {
    static void Main(string[] args)
    {
      var caminho = "E:\\FATEC\\CURSOS\\GITHUB\\PROJETOS-C#\\Dio-progamando\\Softblue-praticas-csharp\\Dio-praticas-c#\\EXEMPLOS";


      var caminhoArquivo = Path.Combine(caminho, "arquivo-texte1.txt");
      var listaString = new List<string> { "Linha1", "Linha2", "Linha3" };
      var listaStringConstinuacao = new List<string> { "Linha4", "Linha5", "Linha6" };

      FileHelper helper = new FileHelper();
      // helper.ListarDiretorios(caminho);
      // helper.ListarArquivosDiretorio(caminho);
      // helper.CriarDiretorio(Path.Combine(caminho,"Pasta"));
      // helper.ApagarDiretorio(caminhoPathCombine)
      // helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrito de arquivo");
     
      // helper.CriarArquivoTextoStream(caminhoArquivo,listaString );
      //  helper.AdicionarTextoStream(caminhoArquivo, listaStringConstinuacao);
      helper.LerArquivoStream(caminhoArquivo);

      // ICalculadora calc = new Calculadora();
      // System.Console.WriteLine(calc.Dividir(10,2));



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
