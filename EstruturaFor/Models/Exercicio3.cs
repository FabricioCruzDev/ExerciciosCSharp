using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace EstruturaFor.Models
{
  public class Exercicio3
  {

    public void Exercicio()
    {
      Console.WriteLine("Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste"
                        + "de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes "
                        + "conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem "
                        + "peso 5.");
      Console.WriteLine("\nDigite a quantidade de testes:");
      int testes = int.Parse(Console.ReadLine());
      string[] valor = new string[3];
      float[] resultados = new float[testes];

      for (int i = 0; i < testes; i++)
      {
        Console.WriteLine("\nDigite 3 valores reais:");
        valor = Console.ReadLine().Split(" ");
        float valor1 = float.Parse(valor[0]) * 2;
        float valor2 = float.Parse(valor[1]) * 3;
        float valor3 = float.Parse(valor[2]) * 5;
        resultados[i] = (valor1 + valor2 + valor3) / 10;
        Console.WriteLine(resultados[i].ToString("F1", CultureInfo.InvariantCulture));
      }
    }
  }
}