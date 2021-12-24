using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
  class Program
  {

    static void Main(string[] args)
    {
      Dictionary<string, string>estados = new Dictionary<string, string>();
      estados.Add("SP","São Paulo");
      estados.Add("MG", "Minas Gerais");
      estados.Add("BA", "Bahia");
      // estados.Add("BA", "");

      foreach(KeyValuePair<string, string>item in estados)
      {
        System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
      }

      string valorprocurado = "BA";
      System.Console.WriteLine("Valor original: ");
      System.Console.WriteLine(estados[valorprocurado]);

      estados[valorprocurado]= "BA - teste atualização";
      System.Console.WriteLine(estados[valorprocurado]);

      // Stack<string> pilhaLivros = new Stack<string>();

      // pilhaLivros.Push(".NET");
      // pilhaLivros.Push("DDD");
      // pilhaLivros.Push("Codigo limpo");

      // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
      // while(pilhaLivros.Count>0)
      // {
      //   System.Console.WriteLine($"Proximo livro para a leitura: {pilhaLivros.Peek()}");
      //   System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
      // }

      // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");


      // Queue<string> fila = new Queue<string>();

      // fila.Enqueue("Donizete");
      // fila.Enqueue("Doni");
      // fila.Enqueue("zete");

      // OperacoesLista opLista = new OperacoesLista();
      // List<string> estado = new List<string> { "SP", "MG", "BA" };
      // string[] estadoArray = new string[2] { "SC", "MT" };

      // estado.Add("SP");
      // estado.Add("MG");
      // estado.Add("BA");

      // System.Console.WriteLine($"Quantidade de elementos na lista: {estado.Count}");

      // opLista.ImprimirListaString(estado);

      // System.Console.WriteLine("Removendo o elemento");
      // estado.Remove("MG");

      // estado.AddRange(estadoArray);
      // estado.Insert(1,"RJ");

      // opLista.ImprimirListaString(estado);

      // for (var i = 0; i < estado.Count; i++)
      // {
      //   System.Console.WriteLine($"indice {i}, Valor: {estado[i]}");
      // }


      //   OperacoesArray op = new OperacoesArray();
      //   int[] array = new int[5] { 6, 38, 1, 9, 2 };
      //   int[] arrayCopia = new int[10];

      //   string[] arrayString = op.ConverterParaStringArray(array);

      //   int valorprocurado = 15;

      // System.Console.WriteLine($"Capacidade atual do arrray: {array.Length}");
      // op.RedimensionarArray(ref array, array.Length*2);

      // System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");

      // int indice = op.ObterIndice(array,valorprocurado);
      // if(indice>-1)
      // {
      //   System.Console.WriteLine("o indice do elemento {0} é: {1}",valorprocurado,indice);
      // }
      // else
      // {
      //   System.Console.WriteLine("Valor não existente no array");
      // }




      // int valorAchado =op.ObterValor(array,valorprocurado);
      // if(valorAchado>0)
      // {
      //   System.Console.WriteLine("Encontrei o valor");
      // }
      // else
      // {
      //   System.Console.WriteLine("não encontrei o valor");
      // }

      // bool TodosMaiorQue =op.TodosMaiorQue(array,valorprocurado);
      // if(TodosMaiorQue)
      // {
      //     System.Console.WriteLine("Todos os valores são maior que {0}",valorprocurado);
      // }
      // else
      // {
      //   System.Console.WriteLine("Existe valores que não são maiores do que {0}", valorprocurado);
      // }
      // bool existe = op.Existe(array, valorprocurado);

      // System.Console.WriteLine("Array original:");
      // op.ImprimirArray(array);


      // if (existe)
      // {
      //   System.Console.WriteLine("Encontrei o valor {0}", valorprocurado);
      // }
      // else
      // {
      //   System.Console.WriteLine("Não encontrei o valor: {0}", valorprocurado);
      // }

      // op.OrdenarBurbleSort(ref array);
      // op.Ordenar(ref array);

      // System.Console.WriteLine("Array ordenado:");
      // op.ImprimirArray(array);

      // System.Console.WriteLine("Array antes da copia");
      // op.ImprimirArray(arrayCopia);

      // op.Copiar(ref array, ref arrayCopia);
      // System.Console.WriteLine("Array após a copia");
      // op.ImprimirArray(arrayCopia);

      // int[,] matriz = new int[4, 2]
      // {
      //     {8,8},
      //     {10,20},
      //     {30,50},
      //     {2,5}
      // };
      // for (var i = 0; i < matriz.GetLength(0); i++)
      // {
      //   for (var j = 0; j < matriz.GetLength(1); j++)
      //   {
      //     System.Console.WriteLine(matriz[i,j]);    
      //   }
      // }




      // int[] arrayInteiros = new int[3];

      // arrayInteiros[0] = 10;
      // arrayInteiros[1] = 20;
      // arrayInteiros[2] = int.Parse("40");

      // arrayInteiros[3]=30;


      // System.Console.WriteLine("Percorrendo o array pelo for");
      // for (int i = 0; i < arrayInteiros.Length; i++)
      // {
      //   System.Console.WriteLine(arrayInteiros[i]);
      // }

      // System.Console.WriteLine("Percorrendo o array pelo ForEach");
      // foreach (int item in arrayInteiros)

      // {
      //   System.Console.WriteLine(item);

      // }

    }
  }

}
