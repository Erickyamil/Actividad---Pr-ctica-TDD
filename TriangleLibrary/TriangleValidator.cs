using System;

namespace TriangleLibrary
{
    public static class TriangleValidator
    {
        private const double Epsilon = 1e-10; // Tolerancia para comparaciones de punto flotante

        /// Determina si tres longitudes pueden formar un triángulo válido.
        /// <param name="a">Primer lado (debe ser positivo y finito).</param>
        /// <param name="b">Segundo lado (debe ser positivo y finito).</param>
        /// <param name="c">Tercer lado (debe ser positivo y finito).</param>
        /// <returns>true si cumplen la desigualdad triangular; false en caso contrario.</returns>
        /// <exception cref="ArgumentException">Se lanza si algún lado no es positivo o no es finito.</exception>
        public static bool IsTriangle(double a, double b, double c)
        {
            ValidateSides(a, b, c);
            return a + b > c && a + c > b && b + c > a;
        }

        // Determina si las longitudes corresponden a un triángulo equilátero (tres lados iguales).
        public static bool IsEquilateral(double a, double b, double c)
        {
            ValidateSides(a, b, c);
            return IsTriangle(a, b, c) && AreEqual(a, b) && AreEqual(b, c);
        }

        // Determina si las longitudes corresponden a un triángulo isósceles (exactamente dos lados iguales).
        public static bool IsIsosceles(double a, double b, double c)
        {
            ValidateSides(a, b, c);
            return IsTriangle(a, b, c) && 
                   (AreEqual(a, b) || AreEqual(b, c) || AreEqual(a, c)) && 
                   !IsEquilateral(a, b, c);
        }

        // Determina si las longitudes corresponden a un triángulo escaleno (todos los lados diferentes).
        public static bool IsScalene(double a, double b, double c)
        {
            ValidateSides(a, b, c);
            return IsTriangle(a, b, c) && 
                   !AreEqual(a, b) && !AreEqual(b, c) && !AreEqual(a, c);
        }

        // Compara dos números de punto flotante con tolerancia.
        private static bool AreEqual(double x, double y) => Math.Abs(x - y) < Epsilon;

        // Valida que los lados sean positivos y finitos.
        private static void ValidateSides(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || 
                double.IsInfinity(a) || double.IsInfinity(b) || double.IsInfinity(c))
                throw new ArgumentException("Los lados deben ser números positivos finitos.");
        }
    }
}