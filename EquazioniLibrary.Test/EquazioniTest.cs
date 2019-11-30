using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        public void TestIsDeterminated()
        {
            double a = 0;
            double b = 5;
            bool risposta_aspettata = true;
            bool risposta = Equazioni.IsDetermined(a,b);
            Assert.AreEqual(risposta_aspettata, risposta);

        }
    }
}
