using System.Globalization;
using ExercicioFixacao1;

Retangulo r = new Retangulo();
Console.WriteLine("Programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe como mostrado no projeto ao lado.");
Console.WriteLine("Digite a largura e a altura do retângulo:");
r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Área = {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Perímetro = {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Diagonal = {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");