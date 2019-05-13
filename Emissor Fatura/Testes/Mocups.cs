using Biblioteca.basicas;
using Biblioteca.utils;
using System;
using System.Collections.Generic;


namespace Testes
{
    internal static class Mocups
    {
        static Random r = new Random();

        private static void Clientes(int quantidade)
        {
            var r = new Random();
            for (int i = 0; i < quantidade; i++)
            {
                Inter.Salvar(
                                new Cliente
                                {
                                    Cnpj = "88.888.888/8888-" + r.Next(10, 99),
                                    Endereco = "Rua do teste de dendereco" + i,
                                    EnderecoBairro = "Bairro teste" + i,
                                    EnderecoCep = "88.888-" + r.Next(100, 999),
                                    EnderecoMunicipio = "Municipio" + i,
                                    EnderecoNumero = "Teste" + i,
                                    Fone = "(81)88888-8888",
                                    InscMunicipal = "88888888888",
                                    Nome = "Teste LTDA" + i,
                                    Uf = "PE"
                                });
            }

        }

        private  static void Emissor(int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            {
                Inter.SalvarEmissor(
                                new Cliente
                                {
                                    Cnpj = "88.888.888/8888-" + r.Next(10, 99),
                                    Endereco = "Rua do teste de dendereco" + i,
                                    EnderecoBairro = "Bairro teste" + i,
                                    EnderecoCep = "88.888-" + r.Next(100, 999),
                                    EnderecoMunicipio = "Municipio" + i,
                                    EnderecoNumero = "Teste" + i,
                                    Fone = "(81)88888-8888",
                                    InscMunicipal = "88888888888",
                                    Nome = "Teste LTDA" + i,
                                    Uf = "PE"
                                });
            }
        }

       
        public static void Faturas(int qntEmissor, int qntCliente, int qntItens, int qntFaturas)
        {
            Emissor(qntEmissor);
            Clientes(qntCliente);
            
            for (int i = 0; i < qntFaturas; i++)
            {
                Inter.Salvar(new Fatura
                {
                    Numero = Inter.UltimoNumero(),
                    Emissor = Inter.Emissor(r.Next(1, qntEmissor)),
                    Cliente = Inter.Cliente(r.Next(1, qntCliente)),
                    Itens = new List<Item> {
                        new Item
                        {
                            Descricao = "Teste " + i,
                            Quantidade = r.Next(),
                            Valor = r.Next()
                        },
                        new Item
                        {
                            Descricao = "Teste " + i,
                            Quantidade = r.Next(),
                            Valor = r.Next()
                        },
                        new Item
                        {
                            Descricao = "Teste " + i,
                            Quantidade = r.Next(),
                            Valor = r.Next()
                        }
                    },

                    Empenho =r.Next(1000,100000).ToString(),
                    DataEmissao = DateTime.Parse("2019/07/" + r.Next(1, 31)),
                    DataRecebimento = DateTime.Parse("2019/07/" + r.Next(1, 31)),
                    TempoPrestacao = r.Next(1, 31) + "meses",
                    Observacao = "Teste de emissão de fatura n " + i

                });
            }
        }

    }
}
