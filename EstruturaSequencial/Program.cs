// Exercício um - ler dois inteiros e mostrar na tela a soma desses números com uma mensagem explicativa

using EstruturaSequencial;

string exercicio;

Console.WriteLine("Exercícios Estrutura Sequencial\n\n");


Console.WriteLine("Escolha o exercício para exibir. De 1 a 6 ou 0 para sair\n");

Console.WriteLine("1 - Ler dois valores inteiros e mostrar na tela a soma desses números.\n");
Console.WriteLine("2 - Ler o valor de um raio de um círculo e mostrar a área do círculo com 4 casas decimais.\n");
Console.WriteLine("3 - Ler quatro valores inteiros (A, B, C, D) e mostrar a diferença entre os produtos AB e CD.\n");
Console.WriteLine("4 - Ler o número de um funcionário, suas horas trabalhadas, valor que ele recebe por cada hora e calcula o salário.\n");
Console.WriteLine("5 - Ler o cógigo, a quantidade e o valor unitário de duas peças, calcular e mostrar o valor a ser pago.\n");
Console.WriteLine("6 - Ler 3 valores com ponto flutuante e calcular áreas de um triângulo, um círculo, um trapésio, um quadrado e um retângulo.\n");

exercicio = Console.ReadLine();
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

  case "4":
    Exercicio4 exe4 = new Exercicio4();
    exe4.Exercicio();
    break;

  case "5":
    Exercicio5 exe5 = new Exercicio5();
    exe5.Exercicio();
    break;

  case "6":
    Exercicio6 exe6 = new Exercicio6();
    exe6.Exercicio();
    break;
}
