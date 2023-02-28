using Exercicios;

int opcao = 0;

Console.WriteLine("1 - Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.");
Console.WriteLine("2 - Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.");

Console.WriteLine("Digite uma opção:");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
  case 1:
    Exercicio1 exe1 = new Exercicio1();
    exe1.Exercicio();
    break;

  case 2:
    Exercicio2 exe2 = new Exercicio2();
    exe2.Exercicio();
    break;

  default:
    Console.WriteLine("Opção inválida");
    break;
}



