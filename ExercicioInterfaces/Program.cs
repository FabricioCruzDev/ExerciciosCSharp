using System.Globalization;
using ExercicioInterfaces.Services;
using ExercicioInterfaces.Entities;

Console.WriteLine("Enter contract data:\n");
Console.Write("Number: ");
int contractNumber = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateOnly contractDate = DateOnly.Parse(Console.ReadLine());
Console.Write("ContractValue: ");
double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int numberOfInstallments = int.Parse(Console.ReadLine());

Contract contract = new Contract(contractNumber, contractDate, contractValue);
ContractService contractService = new ContractService(new PaypalService());

Console.WriteLine("\nInstallments: ");
contractService.ProcessContract(contract, numberOfInstallments);

