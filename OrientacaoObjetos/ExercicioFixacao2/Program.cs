using System;
using System.Globalization;

namespace ExercicioFixacao2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Funcionario f = new Funcionario();

      Console.WriteLine("programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do "
                      + "funcionário (nome e salário líquido). Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o "
                      + "salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário. Use a classe projetada abaixo.");

      Console.WriteLine("Digite os dados do funcionário: ");
      Console.Write("Nome: ");
      f.Nome = Console.ReadLine();
      Console.Write("Salário Bruto: R$ ");
      f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Imposto: R$ ");
      f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine($"Funfionário: {f.ToString()}");

      Console.Write("Digite a porcentagem para aumentar o salário: ");
      double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      f.AumentarSalario(porcentagem);

      Console.WriteLine($"Dados Atualizados: {f.ToString()}");
    }
  }
}