using System.Globalization;
using HerancaPolimorfismo.Entities;
using System.Collections.Generic;

List<Product> product = new List<Product>();
Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
  Console.WriteLine($"Product {i} data:");
  Console.Write("Common, used or imported (c/u/i)? ");
  char productType = char.Parse(Console.ReadLine());
  Console.Write("Name: ");
  string name = Console.ReadLine();
  Console.Write("Price: ");
  double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  switch (productType)
  {
    case 'c':
    product.Add(new Product(name, price));
    break;

    case 'u':
    Console.Write("Manufactore date (DD/MM/YYYY): ");
    DateOnly manufactoreDate = DateOnly.Parse(Console.ReadLine());
    product.Add(new UsedProduct(name, price, manufactoreDate));
    break;

    case 'i':
    Console.Write("Customs fee: ");
    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    product.Add(new ImportedProduct(name, price, customsFee));
    break;

    default:
    Console.WriteLine("DIGITAÇÃO INCORRETA");
    break;
  }
}

Console.WriteLine("\nPRICE TAGS:");

foreach (Product obj in product)
{
  Console.WriteLine(obj.PriceTag());
}

