using System.Collections.Generic;
using System.Globalization;
using ExercicioListas;

List<Employees> employees = new List<Employees>();

Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());


for (int i = 0; i < n; i++)
{
  Console.Write("\nId: ");
  int id = int.Parse(Console.ReadLine());

  Console.Write("Name: ");
  string name = Console.ReadLine();

  Console.Write("Salary: ");
  double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

  employees.Add(new Employees(id, name, salary));
}

Console.Write("Enter the employee id that will have salary increase: ");
int idSearch = int.Parse(Console.ReadLine());

Employees validationId = employees.Find(x => x.Id == idSearch);
if (validationId != null)
{
  int index = employees.FindIndex(x => x.Id == idSearch);
  Console.Write("Enter the percentage: ");
  double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  employees[index].increaseSalary(percentage);
}
else
{
  Console.WriteLine($"ID {idSearch} DOES NOT EXIST!");
}

Console.WriteLine("\nUpdated list of employees:");

foreach (Employees obj in employees)
{
  Console.WriteLine(obj.ToString());
}