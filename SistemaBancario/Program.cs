using System;
using System.Globalization;


namespace SistemaBancario
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Conta conta;
      Console.WriteLine("CADASTRAR CONTA BANCÁRIA\n");
      Console.Write("Informe o número da conta: ");
      int numero = int.Parse(Console.ReadLine());

      Console.Write("Informe o nome do titular da conta: ");
      string titular = Console.ReadLine();

      Console.Write("Haverá depósito inicial? (s / n): ");
      char opcao = char.Parse(Console.ReadLine());

      if (opcao == 's' || opcao == 'S')
      {
        Console.Write("Digite o valor do depósito inicial: ");
        double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta = new Conta(numero, titular, depositoInicial);
        Console.WriteLine("\nDados da conta:");
        Console.WriteLine(conta);
      }
      else
      {
        conta = new Conta(numero, titular);
        Console.WriteLine("\nDados da conta:");
        Console.WriteLine(conta);
      }

      Console.Write("Digite o valor do depósito: ");
      double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      conta.Depositar(valorDeposito);
      Console.WriteLine("\nDados da conta atualizados:");
      Console.WriteLine(conta);

      Console.Write("Digite o valor do saque: ");
      double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      conta.Sacar(valorSaque);
      Console.WriteLine("\nDados da conta atualizados:");
      Console.WriteLine(conta);
    }
  }
}
