using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;


namespace EstruturaCondicional
{
  public class Exercicio7
  {
    float x, y;

    public void exercicio()
    {
      Console.WriteLine("\nDigite o valor de x");
      x = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("\nDigite o valor de y");
      y = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      if (x != 0 && y == 0)
      {
        Console.WriteLine("\nO ponto está no EIXO X");
      }
      else if (x == 0 && y != 0)
      {
        Console.WriteLine("\nO ponto está no EIXO Y");
      }
      else if (x > 0 && y > 0)
      {
        Console.WriteLine("\nO ponto está no Q1");
      }
      else if (x > 0 && y < 0)
      {
        Console.WriteLine("\nO ponto está no Q4");
      }
      else if (x < 0 && y < 0)
      {
        Console.WriteLine("\nO ponto está no Q3");
      }
      else if (x < 0 && y > 0)
      {
        Console.WriteLine("\nO ponto está no Q0");
      }
      else
      {
        Console.WriteLine("\nO ponto está na origem");
      }
    }
  }
}