using NUnit.Framework;
using Calculadora;

namespace Calculadora.Tests
{
    [TestFixture]
    public class OperacionesCombinatoriaTests
    {
        // ── CalcularFactorial ─────────────────────────

        [Test]
        [Description("Factorial de 0 debe ser 1 (caso base)")]
        public void CalcularFactorial_Cero_RetornaUno()
        {
            int resultado = OperacionesCombinatorias.CalcularFactorial(0);
            Assert.That(resultado, Is.EqualTo(1));
        }

        [Test]
        [Description("Factorial de 1 debe ser 1 (caso base)")]
        public void CalcularFactorial_Uno_RetornaUno()
        {
            int resultado = OperacionesCombinatorias.CalcularFactorial(1);
            Assert.That(resultado, Is.EqualTo(1));
        }

        [Test]
        [Description("Factorial de 5 debe ser 120")]
        public void CalcularFactorial_Cinco_RetornaCientoVeinte()
        {
            int resultado = OperacionesCombinatorias.CalcularFactorial(5);
            Assert.That(resultado, Is.EqualTo(120));
        }

        [Test]
        [Description("Factorial de número negativo debe lanzar ArgumentException")]
        public void CalcularFactorial_NumeroNegativo_LanzaArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                OperacionesCombinatorias.CalcularFactorial(-1));
        }

        // ── CalcularCombinaciones ─────────────────────

        [Test]
        [Description("C(5,0) debe ser 1 (elegir 0 elementos)")]
        public void CalcularCombinaciones_KEsCero_RetornaUno()
        {
            int resultado = OperacionesCombinatorias.CalcularCombinaciones(5, 0);
            Assert.That(resultado, Is.EqualTo(1));
        }

        [Test]
        [Description("C(5,5) debe ser 1 (elegir todos los elementos)")]
        public void CalcularCombinaciones_KIgualN_RetornaUno()
        {
            int resultado = OperacionesCombinatorias.CalcularCombinaciones(5, 5);
            Assert.That(resultado, Is.EqualTo(1));
        }

        [Test]
        [Description("C(5,2) debe ser 10")]
        public void CalcularCombinaciones_CincoElegirDos_RetornaDiez()
        {
            int resultado = OperacionesCombinatorias.CalcularCombinaciones(5, 2);
            Assert.That(resultado, Is.EqualTo(10));
        }

        [Test]
        [Description("C(5,6): k mayor que n debe lanzar ArgumentException")]
        public void CalcularCombinaciones_KMayorQueN_LanzaArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                OperacionesCombinatorias.CalcularCombinaciones(5, 6));
        }
    }
}
