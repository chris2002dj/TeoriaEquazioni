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

            double x = 2;

            bool Controllo = EquazioniLibrary.Equazioni.IsDetermined(x, Risultato);

            Assert.AreEqual(Risultato, Controllo);
        }


        [TestMethod]
        public void IsInconsisted()
        {
            bool Risultato = false;

            double x = 0;

            bool Controllo = EquazioniLibrary.Equazioni.IsInconsisted(x, Risultato);

            Assert.AreEqual(Risultato, Controllo);
        }

        
        [TestMethod]
        public void IsDegree2()
        {
            bool Risultato = false;

            double x = 5, y = 2, c = 4;

            bool Controllo = EquazioniLibrary.Equazioni.IsDegree2(x, y, c, Risultato);

            Assert.AreEqual(Risultato, Controllo);
        }
    }
}
