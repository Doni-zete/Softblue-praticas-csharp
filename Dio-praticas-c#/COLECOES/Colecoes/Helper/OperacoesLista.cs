using System.Collections.Generic;

namespace Colecoes.Helper
{
  public class OperacoesLista
  {
    public void ImprimirListaString(List<string> lista)
    {
      for (var i = 0; i < lista.Count; i++)
      {
        System.Console.WriteLine($"indice {i}, Valor: {lista[i]}");
      }
    }
  }
}