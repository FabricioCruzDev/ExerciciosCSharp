using EstruturaWhile.Models;

Console.WriteLine("Exercícios Estrutura While\n\n");


Console.WriteLine("Escolha o exercício para exibir. De 1 a 6 ou 0 para sair\n");

Console.WriteLine("1 - Programa que repita a leitura de uma senha até que ela seja válida.\n");
Console.WriteLine("2 - Ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema"
                  + " cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo"
                  + " será encerrado quando pelo menos uma de duas coordenadas for NULA.\n");
Console.WriteLine("3 - Ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim).\n"
                  + "No fim retorna o total de cada opção");
Console.WriteLine("Qualquer tecla para sair");

string exercicio = Console.ReadLine();
switch (exercicio)
{
  case "1":
    Exercicio1 exe1 = new Exercicio1();
    exe1.Exercicio();
    break;

  case "2":
    Exercicio2 exe2 = new Exercicio2();
    exe2.Exercicio();
    break;

  case "3":
    Exercicio3 exe3 = new Exercicio3();
    exe3.Exercicio();
    break;
  default:
    Console.WriteLine("Fim do programa");
    break;
}
