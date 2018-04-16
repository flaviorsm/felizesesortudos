using System;
using NUnit.Framework;
using Numero_Sortudo_Feliz;

namespace Numero_Sortudo_Feliz.Tests
{
    [TestFixture]
    public class VerificarNumero
    {
        [Test]
        public void ValidaNumero_7()
        {
            var sortudoFeliz = new SortudoFeliz();

            string resultado = sortudoFeliz.VerificarNumero(7);
            Assert.AreEqual("7 - Número Sortudo e Feliz.", resultado);
        }

        [Test]
        public void ValidaNumero_21()
        {
            var sortudoFeliz = new SortudoFeliz();

            string resultado = sortudoFeliz.VerificarNumero(21);
            Assert.AreEqual("21 - Número Sortudo e Não-Feliz.", resultado);
        }

        [Test]
        public void ValidaNumero_28()
        {
            var sortudoFeliz = new SortudoFeliz();

            string resultado = sortudoFeliz.VerificarNumero(28);
            Assert.AreEqual("28 – Número Não-Sortudo e Feliz.", resultado);
        }

        [Test]
        public void ValidaNumero_147()
        {
            var sortudoFeliz = new SortudoFeliz();

            string resultado = sortudoFeliz.VerificarNumero(21);
            Assert.AreEqual("142 – Número Não-Sortudo e Não-Feliz.", resultado);
        }

        [Test]
        public void ValidaNumero_37()
        {
            var sortudoFeliz = new SortudoFeliz();

            string resultado = sortudoFeliz.VerificarNumero(21);
            Assert.AreEqual("37 – Número Sortudo e Não-Feliz.", resultado);
        }

        [Test]
        public void ValidaNumero_100()
        {
            var sortudoFeliz = new SortudoFeliz();

            string resultado = sortudoFeliz.VerificarNumero(21);
            Assert.AreEqual("100 – Número Não-Sortudo e Feliz.", resultado);
        }
    }
}