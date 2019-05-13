using System.Collections.Generic;
using System.IO;

namespace Biblioteca.utils
{
    internal static class Leitura
    {   
        public static List<string> Read(Tipo t)
        {
            var texto = new List<string>();

            string path = Constante.PathData(t);
            Inter.Prepare();
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            foreach (var item in File.ReadAllLines(path))
            {
                texto.Add(item);
            }

            return texto;
        }

        internal static string SelectTipo(Tipo t)
        {
            string path;
            switch (t)
            {

                case Tipo.CLIENTE:
                    {
                        path = "cliente.dat";
                        break;
                    }
               
                case Tipo.FATURA:
                    {
                        path = "fatura.dat";
                        break;
                    }
                case Tipo.EMISSOR:
                    {
                        path = "emissor.dat";
                        break;
                    }
                default:
                    path = "";
                    break;
            }

            return path;

        }

    }
}
