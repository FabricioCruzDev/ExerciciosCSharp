using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace EstruturaCondicional
{
  public class Exercicio5
  {
    string id;
    int quantidade = 0;

    decimal valor = 0, valorTotal = 0;
    public void exercicio()
    {
      Console.WriteLine("\n Escolha o produto");
      Console.WriteLine("\nPara Cachorro Quente Digite: 1");
      Console.WriteLine("\nPara X-Salada Digite: 2");
      Console.WriteLine("\nPara X-Bacon Digite: 3");
      Console.WriteLine("\nPara Torrada simples Digite: 4");
      Console.WriteLine("\nPara Refrigerante Digite: 5");
      id = Console.ReadLine();

      Console.WriteLine("\nDigite a quantidade:");
      quantidade = int.Parse(Console.ReadLine());

      switch (id)
      {
        case "1":
          {
            valor = 4.00M;
            break;
          }
        case "2":
          {
            valor = 4.50M;
            break;
          }
        case "3":
          {
            valor = 5.00M;
            break;
          }
        case "4":
          {
            valor = 2.00M;
            break;
          }
        case "5":
          {
            valor = 1.00M;
            break;
          }
        default:
          {
            Console.WriteLine("OPÇÃO INVÁLIDA");
            break;
          }
      }

      valorTotal = quantidade * valor;

      Console.WriteLine($"Total: R${valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");

    }
  }
}