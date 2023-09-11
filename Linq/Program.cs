using System.Linq;
using System.Globalization;
using Linq.Entities;


internal class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("Enter full file path: ");
    string path = Console.ReadLine();

    List<Employee> list = new List<Employee>();

    try
    {
      using (StreamReader sr = File.OpenText(path))
      {
        while (!sr.EndOfStream)
        {
          string[] fields = sr.ReadLine().Split(',');
          string name = fields[0];
          string email = fields[1];
          double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
          list.Add(new Employee(name, email, salary));
        }
      }

      Console.Write("Enter salary: ");
      double salaryQuery = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("Email of peaple whose salary is more than 2000.00:");

      var salaryMore = list.Where(e => e.Salary > salaryQuery).OrderBy(e => e.Email);

      var sumSalary = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);


      foreach (var result in salaryMore)
      {
        Console.WriteLine(result.Email);
      }

      Console.Write("Sum of salary of peaple whose name starts with 'M': " + sumSalary.ToString("F2", CultureInfo.InvariantCulture));

    }
    catch (IOException e)
    {
      Console.WriteLine("An error ocurred");
      Console.WriteLine(e.Message);
    }
  }
}