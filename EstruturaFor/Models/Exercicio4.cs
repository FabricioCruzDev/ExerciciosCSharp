using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaFor.Models
{
  public class Exercicio4
  {
    int testes;
    double resultado;
    string[] pares = new string[2];
    string erro = "DIVISOR = O - DIVISÃO IMPOSSÍVEL";

    public void Exercicio()
    {
      Console.Write("\nInforme o número de testes: ");
      testes = int.Parse(Console.ReadLine());
      for (int i = 0; i < testes; i++)
      {
        Console.WriteLine($"Digite o {i + 1}º par de números:");
        pares = Console.ReadLine().Split(" ");
        if (pares[1] == "0")
        {
          Console.WriteLine(erro);
        }
        else
        {
          resultado = float.Parse(pares[0]) / float.Parse(pares[1]);
          Console.WriteLine(resultado);
        }
      }
    }

  }
}