using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaCondicional
{
  public class Exercicio3
  {
    int n1, n2;

    public void exercicio()
    {
      Console.WriteLine("\nDigite o primeiro número inteiro:");
      n1 = int.Parse(Console.ReadLine());

      Console.WriteLine("\nDigite o segundo número inteiro:");
      n2 = int.Parse(Console.ReadLine());


      if (n1 % n2 == 0 || n2 % n1 == 0)
      {
        Console.WriteLine($"{n1} e {n2} são múltiplos");
      }
      else
      {
        Console.WriteLine($"{n1} e {n2} não são múltiplos");
      }
    }
  }
}