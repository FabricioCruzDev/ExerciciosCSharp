using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace EstruturaFor.Models
{
  public class Exercicio6
  {
    int numero;

    public void Exercicio()
    {
      Console.WriteLine("\nDigite um número inteiro para encontrarmos os seus divisores: ");
      numero = int.Parse(Console.ReadLine());
      Console.WriteLine($"Os divisores de {numero} são:");
      for (int i = 1; i <= numero; i++)
      {
        if(numero % i == 0)
          Console.WriteLine(i);
      }
    }
  }
}