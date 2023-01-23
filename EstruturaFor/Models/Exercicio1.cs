using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaFor.Models
{
  public class Exercicio1
  {
    protected int n { get; set; }

    public void Exercicio()
    {
      Console.Write("\nDigite um número inteiro entre 1 e 1000: ");
      n = int.Parse(Console.ReadLine());
      if (!(n < 1) && !(n > 1000))
      {
        for (int i = 1; i <= n; i++)
        {
          if (i % 2 != 0)
          {
            Console.WriteLine($"{i} é ímpar");
          }
        }
      }
      else
      {
        Console.WriteLine("Número inválido");
      }
    }
  }
}