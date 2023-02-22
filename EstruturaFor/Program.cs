using EstruturaFor.Models;

string exercicio;

Console.WriteLine("Exercícios Estrutura For\n\n");


Console.WriteLine("Escolha o exercício para exibir. De 1 a 6 ou 0 para sair\n");
Console.WriteLine("1 - Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso..\n");
Console.WriteLine("2 - Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida."
                  + "Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo");
Console.WriteLine("3 - Selecione para ler o enunciado.\n");
Console.WriteLine("4 - Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo segundo. Se o denominador for igual a zero, mostrar a mensagem: DIVISÃO IMPOSSÍVEL.\n");
Console.WriteLine("5 - Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.Lembrando que, por definição, fatorial de 0 é 1\n");
Console.WriteLine("6 - Ler um número inteiro N e calcular todos os seus divisores.\n");
Console.WriteLine("7 - Ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor.\n");
Console.WriteLine("Qualquer tecla para sair");

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

  case "7":
    Exercicio7 exe7 = new Exercicio7();
    exe7.Exercicio();
    break;

  default:
    Console.WriteLine("Fim do programa");
    break;

}