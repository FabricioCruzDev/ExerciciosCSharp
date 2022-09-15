//Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau
//Em seguida, mostrar os valores das raízes da equação, conforme exemplos
// Se a equação não possuir raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser 
//negativo), mostrar uma mensagem "Impossivel calcular". 
using System;
internal class Program
{
  private static void Main(string[] args)
  {
    double a = 0, b = 0, c = 0, delta, x1, x2;
    Console.WriteLine("Digite os coeficientes a, b e c da sua equação:");
    a = Convert.ToDouble(Console.ReadLine());
    b = Convert.ToDouble(Console.ReadLine());
    c = Convert.ToDouble(Console.ReadLine());
    delta = b * b - 4 * a * c;
    if (a == 0 || delta < 0)
      Console.WriteLine("IMPOSSÍVEL CALCULAR");

    Console.WriteLine("Delta = " + delta.ToString("N2"));
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);

    Console.WriteLine("X1 = " + x1.ToString("N2") + "\nX2 = " + x2.ToString("N2"));

  }
}