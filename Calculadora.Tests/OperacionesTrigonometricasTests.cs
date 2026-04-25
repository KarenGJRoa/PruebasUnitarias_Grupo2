using NUnit.Framework;
using Calculadora;

namespace Calculadora.Tests
{
    [TestFixture]
    public class OperacionesTrigonometricasTests
    {
        private const double Tolerancia = 1e-10;

        // ─────────────────────────────────────────────
        // CalcularSeno
        // ─────────────────────────────────────────────

        [Test]
        [Description("Seno de 0 grados debe ser exactamente 0")]
        public void CalcularSeno_Angulo0_RetornaCero()
        {
            double resultado = OperacionesTrigonometricas.CalcularSeno(0);
            Assert.That(resultado, Is.EqualTo(0.0).Within(Tolerancia));
        }

        [Test]
        [Description("Seno de 30 grados debe ser 0.5")]
        public void CalcularSeno_Angulo30_RetornaMedio()
        {
            double resultado = OperacionesTrigonometricas.CalcularSeno(30);
            Assert.That(resultado, Is.EqualTo(0.5).Within(Tolerancia));
        }

        [Test]
        [Description("Seno de 45 grados debe ser √2/2")]
        public void CalcularSeno_Angulo45_RetornaRaiz2Sobre2()
        {
            double esperado = Math.Sqrt(2) / 2;
            double resultado = OperacionesTrigonometricas.CalcularSeno(45);
            Assert.That(resultado, Is.EqualTo(esperado).Within(Tolerancia));
        }

        [Test]
        [Description("Seno de 90 grados debe ser 1 (valor máximo)")]
        public void CalcularSeno_Angulo90_RetornaUno()
        {
            double resultado = OperacionesTrigonometricas.CalcularSeno(90);
            Assert.That(resultado, Is.EqualTo(1.0).Within(Tolerancia));
        }

        [Test]
        [Description("Seno de 180 grados debe ser aproximadamente 0")]
        public void CalcularSeno_Angulo180_RetornaCero()
        {
            double resultado = OperacionesTrigonometricas.CalcularSeno(180);
            Assert.That(resultado, Is.EqualTo(0.0).Within(Tolerancia));
        }

        [Test]
        [Description("Seno de 270 grados debe ser -1 (valor mínimo)")]
        public void CalcularSeno_Angulo270_RetornaUnoNegativo()
        {
            double resultado = OperacionesTrigonometricas.CalcularSeno(270);
            Assert.That(resultado, Is.EqualTo(-1.0).Within(Tolerancia));
        }

        [Test]
        [Description("Seno de 360 grados debe ser aproximadamente 0 (vuelta completa)")]
        public void CalcularSeno_Angulo360_RetornaCero()
        {
            double resultado = OperacionesTrigonometricas.CalcularSeno(360);
            Assert.That(resultado, Is.EqualTo(0.0).Within(Tolerancia));
        }

        [Test]
        [Description("Seno de ángulo negativo -90 grados debe ser -1")]
        public void CalcularSeno_AnguloNegativo90_RetornaUnoNegativo()
        {
            double resultado = OperacionesTrigonometricas.CalcularSeno(-90);
            Assert.That(resultado, Is.EqualTo(-1.0).Within(Tolerancia));
        }

        [Test]
        [Description("Seno de ángulo negativo -45 grados debe ser -√2/2")]
        public void CalcularSeno_AnguloNegativo45_RetornaValorNegativo()
        {
            double esperado = -(Math.Sqrt(2) / 2);
            double resultado = OperacionesTrigonometricas.CalcularSeno(-45);
            Assert.That(resultado, Is.EqualTo(esperado).Within(Tolerancia));
        }

        // ─────────────────────────────────────────────
        // CalcularCoseno
        // ─────────────────────────────────────────────

        [Test]
        [Description("Coseno de 0 grados debe ser 1")]
        public void CalcularCoseno_Angulo0_RetornaUno()
        {
            double resultado = OperacionesTrigonometricas.CalcularCoseno(0);
            Assert.That(resultado, Is.EqualTo(1.0).Within(Tolerancia));
        }

        [Test]
        [Description("Coseno de 60 grados debe ser 0.5")]
        public void CalcularCoseno_Angulo60_RetornaMedio()
        {
            double resultado = OperacionesTrigonometricas.CalcularCoseno(60);
            Assert.That(resultado, Is.EqualTo(0.5).Within(Tolerancia));
        }

        [Test]
        [Description("Coseno de 45 grados debe ser √2/2")]
        public void CalcularCoseno_Angulo45_RetornaRaiz2Sobre2()
        {
            double esperado = Math.Sqrt(2) / 2;
            double resultado = OperacionesTrigonometricas.CalcularCoseno(45);
            Assert.That(resultado, Is.EqualTo(esperado).Within(Tolerancia));
        }

        [Test]
        [Description("Coseno de 90 grados debe ser aproximadamente 0")]
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
        [Description("Coseno de 360 grados debe ser 1 (vuelta completa)")]
        public void CalcularCoseno_Angulo360_RetornaUno()
        {
            double resultado = OperacionesTrigonometricas.CalcularCoseno(360);
            Assert.That(resultado, Is.EqualTo(1.0).Within(Tolerancia));
        }

        [Test]
        [Description("Coseno de ángulo negativo -60 grados debe ser 0.5 (función par)")]
        public void CalcularCoseno_AnguloNegativo60_RetornaMedio()
        {
            double resultado = OperacionesTrigonometricas.CalcularCoseno(-60);
            Assert.That(resultado, Is.EqualTo(0.5).Within(Tolerancia));
        }

        [Test]
        [Description("Coseno de 270 grados debe ser aproximadamente 0")]
        public void CalcularCoseno_Angulo270_RetornaCero()
        {
            double resultado = OperacionesTrigonometricas.CalcularCoseno(270);
            Assert.That(resultado, Is.EqualTo(0.0).Within(Tolerancia));
        }

        // ─────────────────────────────────────────────
        // Identidad trigonométrica: sen²(θ) + cos²(θ) = 1
        // ─────────────────────────────────────────────

        [TestCase(0)]
        [TestCase(30)]
        [TestCase(45)]
        [TestCase(60)]
        [TestCase(90)]
        [TestCase(120)]
        [TestCase(180)]
        [TestCase(270)]
        [TestCase(360)]
        [Description("Identidad fundamental: sen²(θ) + cos²(θ) debe ser igual a 1")]
        public void IdentidadFundamental_SenCuadradoMasCosCuadrado_EsUno(double angulo)
        {
            double seno = OperacionesTrigonometricas.CalcularSeno(angulo);
            double coseno = OperacionesTrigonometricas.CalcularCoseno(angulo);
            double identidad = seno * seno + coseno * coseno;
            Assert.That(identidad, Is.EqualTo(1.0).Within(Tolerancia));
        }
    }
}
