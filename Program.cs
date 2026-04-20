using Calculadora;

Console.WriteLine("Calculadora Avanzada");
Console.WriteLine("=====================\n");

// Ejemplos de uso de las clases
// Clase OperacionesTrigonometricas
double anguloGrados = 45;
double seno = OperacionesTrigonometricas.CalcularSeno(anguloGrados);
Console.WriteLine($"Seno de {anguloGrados} grados: {seno}");


// Clase OperacionesCombinatorias
int n = 5;
int factorial = OperacionesCombinatorias.CalcularFactorial(n);
Console.WriteLine($"Factorial de {n}: {factorial}");

Console.ReadLine();