using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaWhile.Models
{
  public class Exercicio1
  {
    public Exercicio1()
    {
      SenhaCorreta = 2002;
      Senha = 0;
      Validate = false;
    }
    protected int SenhaCorreta { get; set; }
    public int Senha { get; set; }
    protected bool Validate { get; set; }

    public void Exercicio()
    {
      Console.Write("Digie a senha: ");

      while (Senha != SenhaCorreta)
      {
        Senha = int.Parse(Console.ReadLine());
        Console.WriteLine("SENHA INVÁLIDA");
      }
      Validate = true;
      if (Validate)
      {
        Console.WriteLine("Acesso Permitido");
      }
    }
  }
}