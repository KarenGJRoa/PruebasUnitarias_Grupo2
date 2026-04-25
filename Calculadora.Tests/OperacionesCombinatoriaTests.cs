using NUnit.Framework;
using Calculadora;

namespace Calculadora.Tests
{
    [TestFixture]
    public class OperacionesCombinatoriaTests
    {
        // ─────────────────────────────────────────────
        // CalcularFactorial — casos válidos
        // ─────────────────────────────────────────────

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
        [Description("Factorial de 2 debe ser 2")]
        public void CalcularFactorial_Dos_RetornaDos()
        {
            int resultado = OperacionesCombinatorias.CalcularFactorial(2);
            Assert.That(resultado, Is.EqualTo(2));
        }

        [Test]
        [Description("Factorial de 5 debe ser 120")]
        public void CalcularFactorial_Cinco_RetornaCientoVeinte()
        {
            int resultado = OperacionesCombinatorias.CalcularFactorial(5);
            Assert.That(resultado, Is.EqualTo(120));
        }

        [Test]
        [Description("Factorial de 10 debe ser 3628800")]
        public void CalcularFactorial_Diez_RetornaValorCorrecto()
        {
            int resultado = OperacionesCombinatorias.CalcularFactorial(10);
            Assert.That(resultado, Is.EqualTo(3628800));
        }

        [Test]
        [Description("Factorial de 12 debe ser 479001600 (límite máximo para int)")]
        public void CalcularFactorial_Doce_RetornaValorCorrecto()
        {
            int resultado = OperacionesCombinatorias.CalcularFactorial(12);
            Assert.That(resultado, Is.EqualTo(479001600));
        }

        // ─────────────────────────────────────────────
        // CalcularFactorial — casos límite y excepciones
        // ─────────────────────────────────────────────

        [Test]
        [Description("Factorial de número negativo debe lanzar ArgumentException")]
        public void CalcularFactorial_NumeroNegativo_LanzaArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                OperacionesCombinatorias.CalcularFactorial(-1));
        }

        [Test]
        [Description("Factorial de -5 debe lanzar ArgumentException")]
        public void CalcularFactorial_MenosCinco_LanzaArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                OperacionesCombinatorias.CalcularFactorial(-5));
        }

        [Test]
        [Description("El mensaje de la excepción debe indicar que el número debe ser no negativo")]
        public void CalcularFactorial_NumeroNegativo_MensajeExcepcionCorrecto()
        {
            var ex = Assert.Throws<ArgumentException>(() =>
                OperacionesCombinatorias.CalcularFactorial(-1));
            Assert.That(ex.Message, Does.Contain("no negativo").IgnoreCase);
        }

        // ─────────────────────────────────────────────
        // CalcularCombinaciones — casos válidos
        // ─────────────────────────────────────────────

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
        [Description("C(5,3) debe ser 10 (simetría C(n,k) = C(n,n-k))")]
        public void CalcularCombinaciones_CincoElegirTres_RetornaDiez()
        {
            int resultado = OperacionesCombinatorias.CalcularCombinaciones(5, 3);
            Assert.That(resultado, Is.EqualTo(10));
        }

        [Test]
        [Description("C(10,3) debe ser 120")]
        public void CalcularCombinaciones_DiezElegirTres_RetornaCientoVeinte()
        {
            int resultado = OperacionesCombinatorias.CalcularCombinaciones(10, 3);
            Assert.That(resultado, Is.EqualTo(120));
        }

        [Test]
        [Description("C(4,2) debe ser 6")]
        public void CalcularCombinaciones_CuatroElegirDos_RetornaSeis()
        {
            int resultado = OperacionesCombinatorias.CalcularCombinaciones(4, 2);
            Assert.That(resultado, Is.EqualTo(6));
        }

        [Test]
        [Description("C(0,0) debe ser 1 (caso borde con n=0)")]
        public void CalcularCombinaciones_NyCeroKCero_RetornaUno()
        {
            int resultado = OperacionesCombinatorias.CalcularCombinaciones(0, 0);
            Assert.That(resultado, Is.EqualTo(1));
        }

        [Test]
        [Description("C(n,1) debe ser igual a n")]
        public void CalcularCombinaciones_KEsUno_RetornaN()
        {
            int resultado = OperacionesCombinatorias.CalcularCombinaciones(7, 1);
            Assert.That(resultado, Is.EqualTo(7));
        }

        // ─────────────────────────────────────────────
        // CalcularCombinaciones — simetría C(n,k) = C(n,n-k)
        // ─────────────────────────────────────────────

        [TestCase(6, 2)]
        [TestCase(8, 3)]
        [TestCase(10, 4)]
        [Description("C(n,k) debe ser igual a C(n,n-k) por simetría")]
        public void CalcularCombinaciones_Simetria_CnkIgualCnNmenosK(int n, int k)
        {
            int resultado1 = OperacionesCombinatorias.CalcularCombinaciones(n, k);
            int resultado2 = OperacionesCombinatorias.CalcularCombinaciones(n, n - k);
            Assert.That(resultado1, Is.EqualTo(resultado2));
        }

        // ─────────────────────────────────────────────
        // CalcularCombinaciones — excepciones
        // ─────────────────────────────────────────────

        [Test]
        [Description("C(5,-1): k negativo debe lanzar ArgumentException")]
        public void CalcularCombinaciones_KNegativo_LanzaArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                OperacionesCombinatorias.CalcularCombinaciones(5, -1));
        }

        [Test]
        [Description("C(5,6): k mayor que n debe lanzar ArgumentException")]
        public void CalcularCombinaciones_KMayorQueN_LanzaArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                OperacionesCombinatorias.CalcularCombinaciones(5, 6));
        }

        [Test]
        [Description("El mensaje de la excepción debe indicar que k debe estar entre 0 y n")]
        public void CalcularCombinaciones_KInvalido_MensajeExcepcionCorrecto()
        {
            var ex = Assert.Throws<ArgumentException>(() =>
                OperacionesCombinatorias.CalcularCombinaciones(5, 6));
            Assert.That(ex.Message, Does.Contain("k debe estar entre 0 y n").IgnoreCase);
        }
    }
}
