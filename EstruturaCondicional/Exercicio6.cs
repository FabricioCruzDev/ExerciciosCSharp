using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace EstruturaCondicional
{
  public class Exercicio6
  {
    float valor;

    public void exercicio()
    {
      Console.WriteLine("\nDigite um valor para ser verificado:");
      valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      if (0 <= valor && valor <= 25)
      {
        Console.WriteLine("\nEstá no intervalo 0 a 25");
      }
      else if (25 < valor && valor <= 50)
      {
        Console.WriteLine("\nEstá no intervalo 25 a 50");
      }
      else if (50 < valor && valor <= 75)
      {
        Console.WriteLine("\nEstá no intervalo 50 a 75");
      }
      else if (75 < valor && valor <= 100)
      {
        Console.WriteLine("\nEstá no intervalo 75 a 100");
      }
      else
      {
        Console.WriteLine("\nEsse valor não está em nenhum dos intervalos");
      }
    }
  }
}