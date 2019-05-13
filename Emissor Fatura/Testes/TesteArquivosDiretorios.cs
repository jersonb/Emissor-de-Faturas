using Biblioteca.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Testes
{
    [TestClass]
    public class TesteArquivoDiretorio
    {
        [TestInitialize]
        public void Inicializar()
        {
            Inter.Prepare();
        }

      

        [TestMethod]
        public void TesteCriacaoDiretoriosFaturas()
        {
            if (Directory.Exists(Constante.PATH_FATURAS))
            {
                Directory.Delete(Constante.PATH_FATURAS, true);
            }

            Inter.Prepare();

            Assert.IsTrue(Directory.Exists(Constante.PATH_FATURAS));

            Directory.Delete(Constante.PATH_FATURAS);

        }

        [TestCleanup]
        public void Finalizar()
        {
            if (Directory.Exists(Constante.PATH_FATURAS))
            {
                Directory.Delete(Constante.PATH_FATURAS, true);
            }

            if (Directory.Exists(Constante.PATH_FILES))
            {
                Directory.Delete(Constante.PATH_FILES, true);
            }

            if (Directory.Exists(Path.GetDirectoryName(Constante.PathData(Tipo.CLIENTE))))
            {
                Directory.Delete(Path.GetDirectoryName(Constante.PathData(Tipo.CLIENTE)), true);
            }
        }
    }
}
