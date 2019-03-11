using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool Risultato = false;

            int n1 = 1;

            bool Controllo = EquazioniLibrary.Equazioni.Controllo(n1, Risultato);

            Assert.AreEqual(Risultato, Controllo);
        }
    }
}
