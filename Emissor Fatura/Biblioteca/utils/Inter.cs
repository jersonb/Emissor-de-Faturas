using Biblioteca.basicas;
using Biblioteca.controles;
using System;
using System.Collections.Generic;
using System.IO;

namespace Biblioteca.utils
{
    public static class Inter
    {
        static ClienteControle cliente = new ClienteControle();
        static EmissorControle emissor = new EmissorControle();
        static FaturaControle fatura = new FaturaControle();

        #region Cliente
        public static Cliente Salvar(Cliente c)
        {
            return cliente.Salvar(c);
        }

        public static List<Cliente> Clientes()
        {
            return cliente.Listar();
        }

        public static Cliente Cliente(int id)
        {
            return cliente.Listar(id);
        }

        public static void ExisteClienteCadastrado()
        {
            try
            {
                cliente.ExisteClienteCadastrado();
            }
            catch (Exception)
            {

                throw;
            }

        }

        #endregion

        #region Emissor
        public static Cliente SalvarEmissor(Cliente c)
        {
            return emissor.Salvar(c);
        }

        public static List<Cliente> Emissores()
        {
            return emissor.Listar();
        }

        public static Cliente Emissor(int id)
        {
            return emissor.Listar(id);
        }
        public static void ExisteEmissorCadastrado()
        {
            try
            {
                emissor.ExisteEmissorCadastrado();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        #endregion

        #region Fatura
        public static int UltimoNumero()
        {
            return fatura.UltimoNumero();
        }

        public static Fatura Salvar(Fatura f)
        {
            return fatura.Salvar(f);
        }

        public static List<Fatura> Faturas()
        {
            return fatura.Listar();
        }

        public static Fatura Fatura(int id)
        {
            return fatura.Listar(id);
        }
        #endregion

        public static void Prepare()
        {
            if (!Directory.Exists(Constante.PATH_FATURAS))
            {
                Directory.CreateDirectory(Constante.PATH_FATURAS);
            }

            if (!Directory.Exists(Constante.PATH_FILES))
            {
                Directory.CreateDirectory(Constante.PATH_FILES);
            }

            if (!Directory.Exists(Constante.PATH_FILES))
            {
                Directory.CreateDirectory(Constante.PATH_FILES);
            }

            if (!Directory.Exists(Path.GetDirectoryName(Constante.PathData(Tipo.CLIENTE))))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Constante.PathData(Tipo.CLIENTE)));
            }

        }
    }
}
