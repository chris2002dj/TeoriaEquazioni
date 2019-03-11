using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsDetermined()
        {
            bool Risultato = false;

            int x = 2;

            bool Controllo = EquazioniLibrary.Equazioni.IsDetermined(x, Risultato);

            Assert.AreEqual(Risultato, Controllo);
        }

        [TestMethod]
        public void IsInconsisted()
        {
            bool Risultato = false;

            int x = 0;

            bool Controllo = EquazioniLibrary.Equazioni.IsInconsisted(x, Risultato);

            Assert.AreEqual(Risultato, Controllo);
        }
    }
}
