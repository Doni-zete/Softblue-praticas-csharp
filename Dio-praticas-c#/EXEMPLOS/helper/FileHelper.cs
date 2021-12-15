using System.Collections.Generic;
using System.IO;

namespace EXEMPLOS.helper
{
  public class FileHelper
  {
    public void ListarDiretorios(string caminho)
    {
      var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
      foreach (var retorno in retornoCaminho)
      {
        System.Console.WriteLine(retorno);
      }
    }


    public void ListarArquivosDiretorio(string caminho)
    {
      var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);
      foreach (var retorno in retornoArquivos)
      {
        System.Console.WriteLine(retorno);
      }
    }


    public void CriarDiretorio(string caminho)
    {
      var retorno = Directory.CreateDirectory(caminho);
      System.Console.WriteLine(retorno.FullName);
    }


    public void ApagarDiretorio(string caminho)
    {
      Directory.Delete(caminho);

    }
    public void CriarArquivoTexto(string caminho, string conteudo)
    {
      if (!File.Exists(caminho))
      {
        File.WriteAllText(caminho, conteudo);
      }
    }

    public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
    {
      using (var stream = File.CreateText(caminho)) 
      {
        foreach (var linha in conteudo)
        {
          stream.WriteLine(linha);
        }
      }
    }

  }
}

