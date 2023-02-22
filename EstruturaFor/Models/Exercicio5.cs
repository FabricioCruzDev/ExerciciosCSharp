using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace EstruturaFor.Models
{
  public class Exercicio5
  {
    int n, fatorial = 1;
    const int Fatorial_0 = 1;
    public void Exercicio()
    {
      Console.WriteLine("Digite um valor para N que em seguida vamos calcular o seu fatorial");
      n = int.Parse(Console.ReadLine());
      if (n == 0)
      {
        fatorial = Fatorial_0;
      }
      else
      {
        for (int i = 1; i <= n; i++)
        {
          fatorial *= i;
        }
      }
      Console.WriteLine($"O fatorial de {n} é {fatorial}");
    }
  }
}