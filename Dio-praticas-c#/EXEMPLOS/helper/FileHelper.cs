using System.IO;

namespace EXEMPLOS.helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            Directory.GetDirectories(caminho);
        }
    }
}