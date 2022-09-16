using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaCondicional
{
  public class Exercicio4
  {
    int horaInicio, horaFim, duracao;

    public void exercicio()
    {
      Console.WriteLine("\nInforme o início:");
      horaInicio = int.Parse(Console.ReadLine());

      Console.WriteLine("\nInforme o fim:");
      horaFim = int.Parse(Console.ReadLine());

      if (horaInicio < horaFim)
      {
        duracao = horaFim - horaInicio;
        Console.WriteLine($"O jogo durou {duracao} horas");
      }
      else if (horaInicio > horaFim)
      {
        duracao = 24 - horaInicio + horaFim;
        Console.WriteLine($"O jogo durou {duracao} horas");
      }
      else
      {
        Console.WriteLine($"O jogo durou 24dot horas");
      }
    }

  }
}