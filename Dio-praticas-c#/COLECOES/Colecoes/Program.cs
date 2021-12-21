using System;
using Colecoes.Helper;

namespace Colecoes
{
  class Program
  {
    static void Main(string[] args)
    {
      OperacoesArray op = new OperacoesArray();
      int[] array = new int[5] { 6, 38, 1, 9, 2 };
      int[] arrayCopia =new int[10];

      System.Console.WriteLine("Array original:");
      op.ImprimirArray(array);

      // op.OrdenarBurbleSort(ref array);
      op.Ordenar(ref array);
      
      System.Console.WriteLine("Array ordenado:");
      op.ImprimirArray(array);

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
