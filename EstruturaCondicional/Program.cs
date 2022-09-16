
using EstruturaCondicional;

string exercicio;

Console.WriteLine("Exercícios Estrutura Condicional\n\n");


Console.WriteLine("Escolha o exercício para exibir. De 1 a 6 ou 0 para sair\n");

Console.WriteLine("1 - Ler um número inteiro, e depois dizer se este número é negativo ou não.\n");
Console.WriteLine("2 - Ler um número inteiro, e depois dizer se este é par ou ímpar.\n");
Console.WriteLine("3 - Ler dois valores inteiros (A e B) e mostrar se eles são multiplos ou não.\n");
Console.WriteLine("4 - Ler a hora inicial e final de um jogo, sabendo que pode começar em um dia e terminar no outro, duração mínima de 1 hora e máxima de 24 horas.\n");
Console.WriteLine("5 - Verficar a escolha do produto, ler a quantidade desejada e retornar o valor da compra.\n");
Console.WriteLine("6 - Ler um valor e verificar em qual intervalo ele se encontra, (0 a 25, 25 a 50, 50 a 75, 75 a 100).\n");
Console.WriteLine("7 - Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto. Determine qual o quadrante ao qual pertence, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).\n");
Console.WriteLine("8 - Para abrir o exercício 8");
Console.WriteLine("Qualquer tecla para sair");

exercicio = Console.ReadLine();
switch (exercicio)
{
  case "1":
    Exercicio1 exe1 = new Exercicio1();
    exe1.exercicio();
    break;

  case "2":
    Exercicio2 exe2 = new Exercicio2();
    exe2.exercicio();
    break;

  case "3":
    Exercicio3 exe3 = new Exercicio3();
    exe3.exercicio();
    break;

  case "4":
    Exercicio4 exe4 = new Exercicio4();
    exe4.exercicio();
    break;

  case "5":
    Exercicio5 exe5 = new Exercicio5();
    exe5.exercicio();
    break;

  case "6":
    Exercicio6 exe6 = new Exercicio6();
    exe6.exercicio();
    break;

  case "7":
    Exercicio7 exe7 = new Exercicio7();
    exe7.exercicio();
    break;

  case "8":
    Exercicio8 exe8 = new Exercicio8();
    exe8.exercicio();
    break;

  default:
    Console.WriteLine("Fim do programa");
    break;

}