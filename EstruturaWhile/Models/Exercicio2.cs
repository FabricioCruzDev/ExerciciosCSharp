using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaWhile.Models
{
  public class Exercicio2
  {
    public Exercicio2()
    {
      Status = true;

    }
    protected bool Status { get; set; }

    public void Exercicio()
    {
      while (Status)
      {
        Console.Write("\nDigite o valor de x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor de y: ");
        int y = int.Parse(Console.ReadLine());

        if (x == 0 || y == 0)
        {
          Status = false;
        }
        else if (x > 0 && 0 < y)
        {
          Console.WriteLine("Primeiro quadrante");
        }
        else if (x > 0 && 0 > y)
        {
          Console.WriteLine("Segundo quadrante");
        }
        else if (x < 0 && 0 > y)
        {
          Console.WriteLine("Terceiro quadrante");
        }
        else if (x < 0 && 0 < y)
        {
          Console.WriteLine("Quarto quadrante");
        }
      }
    }
  }
}
