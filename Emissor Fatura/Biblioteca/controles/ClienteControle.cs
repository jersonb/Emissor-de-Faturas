using Biblioteca.basicas;
using Biblioteca.daos;
using System;
using System.Collections.Generic;

namespace Biblioteca.controles
{
    public class ClienteControle
    {
        ClienteDao dao = new ClienteDao();

        public Cliente Salvar(Cliente c)
        {
            var cliente = new Cliente
            {
                Id = c.Id,
                Cnpj = c.Cnpj,
                Endereco = c.Endereco.ToUpper().PadLeft(100,' ').Substring(0, 100).Trim(),
                EnderecoBairro = c.EnderecoBairro.ToUpper().PadLeft(100, ' ').Substring(0, 100).Trim(),
                EnderecoCep = c.EnderecoCep,
                EnderecoMunicipio = c.EnderecoMunicipio.ToUpper().PadLeft(100, ' ').Substring(0, 100).Trim(),
                EnderecoNumero = c.EnderecoNumero.ToUpper().PadLeft(100, ' ').Substring(0, 100).Trim(),
                Fone = c.Fone,
                InscMunicipal = c.InscMunicipal,
                Nome = c.Nome.ToUpper().PadLeft(100, ' ').Substring(0, 100).Trim(),
                Uf = c.Uf.ToUpper().PadLeft(2, ' ').Substring(0, 2).Trim(),
            };

            try
            {
                return dao.Salvar(Verificar(cliente));
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        public void ExisteClienteCadastrado()
        {
            if (Listar().Count == 0)
            {
                throw new Exception("Cadastre ao menos um Cliente");
            }

        }

        public List<Cliente> Listar()
        {
            return dao.Listar();
        }

        public Cliente Listar(int id)
        {
            return dao.Listar(id);
        }

        private Cliente Verificar(Cliente c)
        {
            if (string.IsNullOrEmpty(c.Nome))
            {
                throw new Exception("Insira um nome válido");
            }

            if (string.IsNullOrEmpty(c.Cnpj))
            {
                throw new Exception("Insira um CNPJ válido");
            }

            if (string.IsNullOrEmpty(c.InscMunicipal))
            {
                throw new Exception("Insira uma Inscrição Municipal válido");
            }

            if (string.IsNullOrEmpty(c.Endereco))
            {
                throw new Exception("Insira um endereço válido");
            }

            if (string.IsNullOrEmpty(c.EnderecoBairro))
            {
                throw new Exception("Insira um bairro válido");
            }

            if (string.IsNullOrEmpty(c.EnderecoCep))
            {
                throw new Exception("Insira um CEP válido");
            }

            if (string.IsNullOrEmpty(c.EnderecoMunicipio))
            {
                throw new Exception("Insira um município válido");
            }

            if (string.IsNullOrEmpty(c.EnderecoNumero))
            {
                throw new Exception("Insira um número válido");
            }

            if (string.IsNullOrEmpty(c.Uf))
            {
                throw new Exception("Insira uma UF válida");
            }

            return c;
        }
    }
}
