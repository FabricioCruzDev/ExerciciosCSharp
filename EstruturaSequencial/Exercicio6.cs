using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace EstruturaSequencial
{
  public class Exercicio6
  {
    double a, b, c, d, pi = 3.14159;


    public void Exercicio()
    {
      Console.WriteLine("Entrada dos dados");

      Console.WriteLine("\nValor de A:");
      a = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("\nValor de B:");
      b = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("\nValor de C:");
      c = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);



      double areaTriangulo = (a * c) / 2;
      Console.WriteLine($"Área do triângulo retângulo que tem {a} por base e {c} por altura\né igual a: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");

      double areaCirculo = pi * Math.Pow(c, 2);
      Console.WriteLine($"Área do círculo de raio = {c}\né igual a {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");

      double areaTrapezio = ((a + b) * c) / 2;
      Console.WriteLine($"Área do trapésio com bases {a} e {b}, e altura igual a {c}\né igual a {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");

      double areaQuadrado = b * b;
      Console.WriteLine($"Área do quadrado com lado igual a {b}\né igual a {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");

      double areaRetangulo = a * b;
      Console.WriteLine($"Área do retângulado com lados {a} e {b}\né igual a {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
    }
  }
}