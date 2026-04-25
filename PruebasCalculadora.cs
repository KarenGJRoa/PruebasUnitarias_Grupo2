using NUnit.Framework;
using Calculadora;

namespace Calculadora.Tests
{     
    public class PruebasCalculadora 
    {
        [Test]
        public void Seno_90_DebeSer1()
        {
            var resultado = OperacionesTrigonometricas.CalcularSeno(90);
            Assert.AreEqual(1, resultado, 0.0001);
        }

        [Test]
        public void Coseno_0_DebeSer1()
        {
            var resultado = OperacionesTrigonometricas.CalcularCoseno(0);
            Assert.AreEqual(1, resultado, 0.0001);
        }

        [Test]
        public void Factorial_5_DebeSer120()
        {
            var resultado = OperacionesCombinatorias.CalcularFactorial(5);
            Assert.AreEqual(120, resultado);
        }

        [Test]
        public void Factorial_0_DebeSer1()
        {
            var resultado = OperacionesCombinatorias.CalcularFactorial(0);
            Assert.AreEqual(1, resultado);
        }

        [Test]
        public void Combinaciones_5_2_DebeSer10()
        {
            var resultado = OperacionesCombinatorias.CalcularCombinaciones(5, 2);
            Assert.AreEqual(10, resultado);
        }

        [Test]
        public void Combinaciones_5_5_DebeSer1()
        {
            var resultado = OperacionesCombinatorias.CalcularCombinaciones(5, 5);
            Assert.AreEqual(1, resultado);
        }

        [Test]
        public void Factorial_Negativo_DebeLanzarError()
        {
            Assert.Throws<System.ArgumentException>(() =>
                OperacionesCombinatorias.CalcularFactorial(-1));
        }

        [Test]
        public void Combinaciones_kMayorQueN_DebeLanzarError()
        {
            Assert.Throws<System.ArgumentException>(() =>
                OperacionesCombinatorias.CalcularCombinaciones(3, 5));
        }
    }
}