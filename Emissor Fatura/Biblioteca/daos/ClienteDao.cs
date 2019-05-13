using Biblioteca.basicas;
using Biblioteca.utils;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Biblioteca.daos
{
    internal class ClienteDao : EntidadeDao
    {
        private string caminhoArquivo = Constante.PathData(Tipo.CLIENTE);
        
        public Cliente Salvar(Cliente c)
        {
            if (c.Id == 0 )
            {
                c.Id = AtualId();
            }

            File.AppendAllText(caminhoArquivo, Encode(c.ToJson()) + "\n");
            return c;
        }


        public List<Cliente> Listar()
        {
            return Leitura.Read(Tipo.CLIENTE).Select(o => JsonConvert.DeserializeObject<Cliente>(Decode(o)))
                                               .OrderBy(o => o.Nome)
                                               .ToList();
        }

        public Cliente Listar(int id)
        {
            return Listar().Find(o => o.Id.Equals(id));
        }

        private int AtualId()
        {
            var list = Listar().OrderBy(e => e.Id).ToList();
            return list.Count() == 0 || list == null ? 1 : list.ElementAt(list.Count - 1).Id + 1;
        }    

    }
}
