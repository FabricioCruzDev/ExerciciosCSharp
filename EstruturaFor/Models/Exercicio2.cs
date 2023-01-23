using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaFor.Models
{
  public class Exercicio2
  {

    protected int N { get; set; }
    protected int In { get; set; }
    protected int Out { get; set; }


    public void Exercicio()
    {
      Console.Write("\nDigite um número inteiro: ");
      N = int.Parse(Console.ReadLine());
      if (N > 0)
      {
        for (int i = 0; i < N; i++)
        {
          Console.Write($"\nDigite o {i + 1}º de {N}: ");
          int numeros = int.Parse(Console.ReadLine());
          if ((10 <= numeros) && (numeros <= 20))
          {
            In++;
          }
          else
          {
            Out++;
          }
        }
        Console.WriteLine($"\n{In} In.\n{Out} out.");
      }
      else
      {
        Console.WriteLine("Número inválido");
      }
    }
  }
}