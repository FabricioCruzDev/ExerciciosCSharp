using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaCondicional
{
  public class Exercicio1
  {
    int n;

    public void exercicio()
    {
      Console.WriteLine("\nDigite um número inteiro:");
      n = int.Parse(Console.ReadLine());

      if (n < 0)
      {
        Console.WriteLine($"O número {n} é negativo");
      }
      else
      {
        Console.WriteLine($"O número {n} é positivo");
      }
    }
  }
}