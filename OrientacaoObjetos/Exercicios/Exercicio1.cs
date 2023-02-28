using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicios.Models;

namespace Exercicios
{
  public class Exercicio1
  {
    public void Exercicio()
    {
      Pessoa pessoa1 = new Pessoa();
      Console.WriteLine("Digite o nome da 1º pessoa: ");
      pessoa1.Nome = Console.ReadLine();
      Console.WriteLine("Digite a idade: ");
      pessoa1.Idade = int.Parse(Console.ReadLine());

      Pessoa pessoa2 = new Pessoa();
      Console.WriteLine("Digite o nome da 2º pessoa: ");
      pessoa1.Nome = Console.ReadLine();
      Console.WriteLine("Digite a idade: ");
      pessoa1.Idade = int.Parse(Console.ReadLine());

      if (pessoa1.Idade > pessoa2.Idade)
        Console.WriteLine($"Pessoa mais velho(a): {pessoa1.Nome}");
      else
        Console.WriteLine($"Pessoa mais velho(a): {pessoa2.Nome}");
    }
  }
}