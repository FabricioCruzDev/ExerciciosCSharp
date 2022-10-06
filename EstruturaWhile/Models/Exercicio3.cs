using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaWhile.Models
{
  public class Exercicio3
  {
    public Exercicio3()
    {
      CodigoCombustivel = 0;
      Alcool = 0;
      Gasolina = 0;
      Diesel = 0;
    }
    protected int CodigoCombustivel { get; set; }
    protected int Alcool { get; set; }
    protected int Gasolina { get; set; }
    protected int Diesel { get; set; }
    public void Exercicio()
    {
      while (CodigoCombustivel != 4)
      {
        Console.WriteLine("Insira o código do combustível");
        Console.Write("(1.Álcool 2.Gasolina 3.Diesel 4.Fim): ");
        CodigoCombustivel = int.Parse(Console.ReadLine());
        switch (CodigoCombustivel)
        {
          case 1:
            Alcool++;
            break;

          case 2:
            Gasolina++;
            break;

          case 3:
            Diesel++;
            break;

          case 4:
            Console.WriteLine("\nCalculando.......");
            break;

          default:
            Console.WriteLine("\nCódigo inválido.");
            break;
        }
      }
      Console.WriteLine($"Muito obrigado.\n{Alcool} clientes abasteceram com Álcool");
      Console.WriteLine($"{Gasolina} clientes abasteceram com Gasolina");
      Console.WriteLine($"{Diesel} clientes abasteceram com Diesel");
    }
  }
}