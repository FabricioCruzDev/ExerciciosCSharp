using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicios.Models;
using System.Globalization;

namespace Exercicios
{
  public class Exercicio2
  {
    double MediaSalario;
    public void Exercicio()
    {
      Funcionarios funcionario1 = new Funcionarios();
      Console.WriteLine("Digite o nome do 1º funcionário: ");
      funcionario1.Nome = Console.ReadLine();
      Console.WriteLine("Digite a salário: ");
      funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Funcionarios funcionario2 = new Funcionarios();
      Console.WriteLine("Digite o nome do 1º funcionário: ");
      funcionario2.Nome = Console.ReadLine();
      Console.WriteLine("Digite a salário: ");
      funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      MediaSalario = (funcionario1.Salario + funcionario2.Salario) / 2;

      Console.WriteLine($"A média dos salário é: R${MediaSalario.ToString("F2", CultureInfo.InvariantCulture)}");
    }
  }
}