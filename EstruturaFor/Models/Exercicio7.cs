using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace EstruturaFor.Models
{
  public class Exercicio7
  {
    int numero;

    public void Exercicio()
    {
      //Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor
      Console.WriteLine("\nDigite um número positivo: ");
      numero = int.Parse(Console.ReadLine());
      for (int i = 1; i <= numero; i++)
      {
        if(numero > 0)
          Console.WriteLine($"{i} {i * i} {i * i * i}");
        else
          Console.WriteLine("Número inválido");
      }
    }
  }
}