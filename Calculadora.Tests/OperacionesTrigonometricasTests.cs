using NUnit.Framework;
using Calculadora;

namespace Calculadora.Tests
{
    [TestFixture]
    public class OperacionesTrigonometricasTests
    {
        private const double Tolerancia = 1e-10;

        // ── CalcularSeno ──────────────────────────────

        [Test]
        [Description("Seno de 0 grados debe ser 0")]
        public void CalcularSeno_Angulo0_RetornaCero()
        {
            double resultado = OperacionesTrigonometricas.CalcularSeno(0);
            Assert.That(resultado, Is.EqualTo(0.0).Within(Tolerancia));
        }

        [Test]
        [Description("Seno de 90 grados debe ser 1 (valor máximo)")]
        public void CalcularSeno_Angulo90_RetornaUno()
        {
            double resultado = OperacionesTrigonometricas.CalcularSeno(90);
            Assert.That(resultado, Is.EqualTo(1.0).Within(Tolerancia));
        }

        [Test]
        [Description("Seno de 180 grados debe ser 0")]
        public void CalcularSeno_Angulo180_RetornaCero()
        {
            double resultado = OperacionesTrigonometricas.CalcularSeno(180);
            Assert.That(resultado, Is.EqualTo(0.0).Within(Tolerancia));
        }

        [Test]
        [Description("Seno de ángulo negativo -90 grados debe ser -1")]
        public void CalcularSeno_AnguloNegativo90_RetornaUnoNegativo()
        {
            double resultado = OperacionesTrigonometricas.CalcularSeno(-90);
            Assert.That(resultado, Is.EqualTo(-1.0).Within(Tolerancia));
        }

        // ── CalcularCoseno ────────────────────────────

        [Test]
        [Description("Coseno de 0 grados debe ser 1")]
        public void CalcularCoseno_Angulo0_RetornaUno()
        {
            double resultado = OperacionesTrigonometricas.CalcularCoseno(0);
            Assert.That(resultado, Is.EqualTo(1.0).Within(Tolerancia));
        }

        [Test]
        [Description("Coseno de 90 grados debe ser 0")]
        public void CalcularCoseno_Angulo90_RetornaCero()
        {
            double resultado = OperacionesTrigonometricas.CalcularCoseno(90);
            Assert.That(resultado, Is.EqualTo(0.0).Within(Tolerancia));
        }

        [Test]
        [Description("Coseno de 180 grados debe ser -1")]
        public void CalcularCoseno_Angulo180_RetornaUnoNegativo()
        {
            double resultado = OperacionesTrigonometricas.CalcularCoseno(180);
            Assert.That(resultado, Is.EqualTo(-1.0).Within(Tolerancia));
        }

        [Test]
        [Description("Coseno de ángulo negativo -60 grados debe ser 0.5 (función par)")]
        public void CalcularCoseno_AnguloNegativo60_RetornaMedio()
        {
            double resultado = OperacionesTrigonometricas.CalcularCoseno(-60);
            Assert.That(resultado, Is.EqualTo(0.5).Within(Tolerancia));
        }
    }
}
