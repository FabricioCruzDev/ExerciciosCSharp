using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;


namespace EstruturaCondicional
{
  public class Exercicio8
  {
    double salario, imposto, taxa;

    public void exercicio()
    {
      Console.WriteLine("\nEm um país imaginário denominado Lisarb, todos os habitantes ficam\nfelizes em pagar seus impostos, pois sabem que nele\nnão existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população,\nsem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.");
      Console.WriteLine("\nLeia um valor com duas casas decimais, equivalente ao salário de uma\n pessoa de Lisarb. Em seguida, calcule e mostre o\nvalor que esta pessoa deve pagar de Imposto de Renda");

      Console.WriteLine("\nDigite o valor do salário");
      salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      if (salario <= 2000)
      {
        Console.WriteLine("\nINSENTO do imposto de renda");
      }
      else if (2000 < salario && salario < 3000)
      {
        imposto = (salario - 2000) * 0.08;
      }
      else if (salario > 3000 && salario < 4500)
      {
        imposto = 1000 * 0.08 + (salario - 3000) * 0.18;
      }
      else
      {
        taxa = 28;
        imposto = 1000 * 0.08 + 1500 * 0.18 + (salario - 4500) * 0.28;
      }

      Console.WriteLine($"Com o salário de R${salario.ToString("F2", CultureInfo.InvariantCulture)},\no imposto será igual a R${imposto.ToString("F2", CultureInfo.InvariantCulture)}.");
    }
  }
}