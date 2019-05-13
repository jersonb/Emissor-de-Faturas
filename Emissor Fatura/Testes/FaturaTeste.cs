using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testes
{
    [TestClass]
    public class FaturaTeste
    {
        [TestInitialize]
        public void Inicializar() { }

        [TestMethod]
        public void TestarGeracaoDeFaturas()
        {
            Mocups.Faturas(1, 10, 3, 20);

        }

        [TestCleanup]
        public void Finalizar() { }
    }
}
