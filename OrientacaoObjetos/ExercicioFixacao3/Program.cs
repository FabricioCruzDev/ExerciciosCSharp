﻿using System;
using System.Globalization;

namespace ExercicioFixacao3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Aluno aluno = new Aluno();

      Console.WriteLine("programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano "
                        + "(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no "
                        + "ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam "
                        + "para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este problema");

      Console.Write("Nome do aluno: ");
      aluno.Nome = Console.ReadLine();

      Console.WriteLine("Digite as três notas do aluno: ");
      aluno.NotaTrimestre1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      aluno.NotaTrimestre2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      aluno.NotaTrimestre3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
      if (aluno.Aprovado())
      {
        Console.WriteLine("APROVADO");
      }
      else
      {
        Console.WriteLine("REPROVADO\nFALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
      }
    }
  }
}