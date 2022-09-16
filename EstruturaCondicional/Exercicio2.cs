using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaCondicional
{
  public class Exercicio2
  {
    int n;

    public void exercicio()
    {
      Console.WriteLine("\nDigite um número inteiro:");
      n = int.Parse(Console.ReadLine());
      if (n % 2 == 0)
      {
        Console.WriteLine($"O número {n} é PAR");
      }
      else
      {
        Console.WriteLine($"O número {n} é ÍMPAR");
      }
    }
  }
}