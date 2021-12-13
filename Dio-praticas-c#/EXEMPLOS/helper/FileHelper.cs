using System.IO;

namespace EXEMPLOS.helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho= Directory.GetDirectories(caminho);
            foreach(var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
    }
}