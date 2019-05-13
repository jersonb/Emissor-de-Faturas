using Biblioteca.utils;
using System.IO;

namespace Backup
{
    public static class Backup
    {
        public static void Gerar(string newPath)
        {
            var pathCliente = Constante.PathData(Tipo.CLIENTE);
            var path = Path.GetDirectoryName(pathCliente);
            var list = Directory.GetFiles(path, "*.dat");

            try
            {
                foreach (var item in list)
                {
                    string novo = string.Concat(newPath, @"\backup_faturas\" ,Path.GetFileName(item));

                    if (!Directory.Exists(Path.GetDirectoryName(novo)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(novo));
                    }

                    File.Copy(item,novo,true);

                }
            }
            catch (System.Exception)
            {

                throw;
            }
           
           
        }

        public static void Importar(string oldPath)
        {
            var pathCliente = Constante.PathData(Tipo.CLIENTE);
            var path = Path.GetDirectoryName(pathCliente);
            var list = Directory.GetFiles(oldPath, "*.dat");

            try
            {
                foreach (var item in list)
                {
                    string novo = Path.GetDirectoryName(Constante.PathData(Tipo.CLIENTE));

                    if (!Directory.Exists(novo))
                    {
                        Directory.CreateDirectory(novo);
                    }
                    string i = string.Concat(novo, @"\", Path.GetFileName(item));
                    File.Copy(item,i,true );

                }
            }
            catch (System.Exception)
            {

                throw;
            }


        }

    }
}
