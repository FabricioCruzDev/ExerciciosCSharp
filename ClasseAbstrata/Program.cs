using System.Globalization;
using System.Collections.Generic;
using ClasseAbstrata.Entities;

List<Payer> payers = new List<Payer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
  Console.WriteLine($"Tax payer {i} data: ");
  Console.Write("Individual or company(i/c): ");
  char option = char.Parse(Console.ReadLine());
  Console.Write("Name: ");
  string name = Console.ReadLine();
  Console.Write("Anual income: ");
  double anual_income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  if (option == 'i')
  {
    Console.Write("Health expenditures: ");
    double health_expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    payers.Add(new Individual(name, anual_income, health_expenditures));
  }
  else if (option == 'c')
  {
    Console.Write("Number of employees: ");
    int number_employees = int.Parse(Console.ReadLine());
    payers.Add(new Company(name, anual_income, number_employees));
  }
  else
  {
    i -= 1;
    Console.WriteLine("OPÇÃO INVÁLIDA");
  }

  Console.WriteLine("-----------------------");
}

Console.WriteLine("\nTAXES PAID:");

double totalTaxes = 0.0;
foreach (Payer payer in payers)
{
  Console.WriteLine(payer.Name
  + ":   $" + payer.TaxPaid().ToString("F2", CultureInfo.InvariantCulture));
  totalTaxes += payer.TaxPaid();
}

Console.WriteLine($"\nTOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
