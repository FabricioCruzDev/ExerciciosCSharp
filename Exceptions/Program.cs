using System.Globalization;
using Exceptions.Entities;
using Exceptions.Entities.Exceptions;

try
{
  Console.WriteLine("\nEnter account data");
  Console.Write("Number: ");
  int number = int.Parse(Console.ReadLine());
  Console.Write("Holder: ");
  string holder = Console.ReadLine();
  Console.Write("Initial balance: : ");
  double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  Console.Write("Withdraw limit: : ");
  double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

  Account account = new Account(number, holder, balance, withdrawLimit);

  Console.Write("\nEnter amount for withdraw: ");
  double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  account.Withdraw(amount);

  Console.WriteLine(account);
}

catch (DomainException e)
{
  Console.WriteLine("Withdraw error: " + e.Message);
}

catch (FormatException e)
{
  Console.WriteLine("Format error: " + e.Message);
}

catch (Exception e)
{
  Console.WriteLine("Unexpected error: " + e.Message);
}
