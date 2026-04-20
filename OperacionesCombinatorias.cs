using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class OperacionesCombinatorias
    {
        public static int CalcularFactorial(int n)
        {
            if (n < 1)
                throw new ArgumentException("El número debe ser no negativo.");

            if (n == 0 || n == 1)
                return 1;

            int resultado = 1;
            for (int i = 2; i < n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public static int CalcularCombinaciones(int n, int k)
        {
            if (k < 0 || k > n)
                throw new ArgumentException("k debe estar entre 0 y n.");

            int factorialN = CalcularFactorial(n);
            int factorialK = CalcularFactorial(k);
            int factorialNMinusK = CalcularFactorial(n - k);

            return factorialN / (factorialK * factorialNMinusK);
        }
    }
}
