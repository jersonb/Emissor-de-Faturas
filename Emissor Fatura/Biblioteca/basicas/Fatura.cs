    using System;
using System.Collections.Generic;

namespace Biblioteca.basicas
{
    
    public class Fatura : Entidade
    {
        public int Numero { get; set; }
        public Cliente Emissor { get; set;}
        public Cliente Cliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Empenho { get; set; }
        public decimal ValorTotal { get; set; }

        public List<Item> Itens { get; set; }
       
        public DateTime DataRecebimento { get; set; }
        public string TempoPrestacao { get; set; }
        public string Observacao { get; set; }

        
    }
}
