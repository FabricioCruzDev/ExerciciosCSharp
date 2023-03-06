using System;
using System.Globalization;

namespace SistemaBancario
{
  public class Conta
  {
    public int NumeroConta { get; private set; }
    public string NomeTitular { get; set; }
    public double Saldo { get; private set; }
    private double _taxaSaque = 5.00;

    public Conta(int numeroConta, string nomeTitular)
    {
      NumeroConta = numeroConta;
      NomeTitular = nomeTitular;
    }

    public Conta(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
    {
      Depositar(depositoInicial);
    }

    public void Depositar(double valorDeposito)
    {
      Saldo += valorDeposito;
    }

    public void Sacar(double valorSaque)
    {
      if (valorSaque > 0)
        Saldo -= valorSaque + _taxaSaque;
    }

    public override string ToString()
    {
      return $"Número: {NumeroConta}\n"
            + $"Nome Titular: {NomeTitular}\n"
            + $"Saldo Atual: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
    }
  }
}