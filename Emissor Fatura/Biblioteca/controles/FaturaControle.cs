using Biblioteca.basicas;
using Biblioteca.daos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.controles
{
    public class FaturaControle
    {
        FaturaDao dao = new FaturaDao();

        private Fatura Verificar(Fatura f)
        {
            if (f.Cliente == null)
            {
                throw new Exception("Cliente inválido, selecione um cliente!");
            }

            if (f.Emissor == null)
            {
                throw new Exception("Emmissor inválido, selecione um emissor!");
            }

            if (f.DataEmissao == null)
            {
                throw new Exception("Selecione uma data de emissão válida!");
            }

            if (f.Itens == null || f.Itens.Count == 0)
            {
                throw new Exception("É necessário inserir ao menos um item na fatura");
            }

            foreach (var item in f.Itens)
            {
                if ( string.IsNullOrEmpty(item.Descricao))
                {
                    throw new Exception("É necessário inserir uma descrição válida aos item");
                }

                if (item.Quantidade <= 0)
                {
                    throw new Exception("Insira uma quantidade válida ao item");
                }

                if (item.Valor <=0)
                {
                    throw new Exception("Insira um valor válido ao item");
                }
            }
           
            return f;
        }

        public Fatura Salvar(Fatura f)
        {
            f.ValorTotal = f.Itens.Sum(o => (o.Valor * o.Quantidade));
            
            try
            {
                return dao.Salvar(Verificar(f));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Fatura> Listar()
        {
            return dao.Listar();
        }

        public Fatura Listar(int id)
        {
            return dao.Listar(id);
        }

        public int UltimoNumero()
        {
            return dao.AtualNumber();
        }
    }
}
