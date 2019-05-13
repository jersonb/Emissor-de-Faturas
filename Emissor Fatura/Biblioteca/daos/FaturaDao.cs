using Biblioteca.basicas;
using Biblioteca.utils;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Biblioteca.daos
{
    internal class FaturaDao : EntidadeDao
    {
        private string caminhoArquivo = Constante.PathData(Tipo.FATURA);
        
        public Fatura Salvar(Fatura f)
        {
            if (f.Id == 0)
            {
                f.Id = AtualId();
            }
           
            File.AppendAllText(caminhoArquivo, Encode(f.ToJson()) + "\n");
            return f;
        }


        public List<Fatura> Listar()
        {
            return Leitura.Read(Tipo.FATURA).Select(o => JsonConvert.DeserializeObject<Fatura>(Decode(o)))
                                               .OrderBy(o => o.Numero)
                                               .ToList();
        }

        public Fatura Listar(int id)
        {
            return Listar().Find(o => o.Id.Equals(id));
        }

        private int AtualId()
        {
            var list = Listar().OrderBy(e => e.Id).ToList();
            return list.Count() == 0 || list == null ? 1 : list.ElementAt(list.Count - 1).Id + 1;
        }

        public int AtualNumber()
        {
            var list = Listar().OrderBy(e => e.Numero).ToList();
            return list.Count() == 0 || list == null ? 1 : list.ElementAt(list.Count - 1).Id + 1;
        }
    }
}
