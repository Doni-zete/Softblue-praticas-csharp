using System.IO;

namespace EXEMPLOS.helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho= Directory.GetDirectories(caminho,"*",SearchOption.AllDirectories);
            foreach(var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }


        public void ListarArquivosDiretorio(string caminho)
        {
             var retornoArquivos= Directory.GetFiles(caminho);
             foreach(var retorno in retornoArquivos)
             {
                 System.Console.WriteLine(retorno);
             }
        }
    }
}