using System.IO;
using TrabalalhandoComArquivos;
using System.Globalization;

List<Product> productSolded = new List<Product>();
Console.Write("Enter file full path: ");
string path = Console.ReadLine();

try
{
  using (FileStream fs = new FileStream(path, FileMode.Open))
  {
    using (StreamReader sr = new StreamReader(fs))
    {
      while (!sr.EndOfStream)
      {
        string line = sr.ReadLine();
        string product = line.Split(',')[0];
        double price = double.Parse(line.Split(',')[1], CultureInfo.InvariantCulture);
        int quantity = int.Parse(line.Split(',')[2]);
        Product p = new Product(product, price, quantity);
        productSolded.Add(p);
      }
    }
  }

  string source = Path.GetDirectoryName(path);
  Directory.CreateDirectory(source + @"\out");
  string targetPath = source + @"\out\summary.csv";

  using (StreamWriter ws = File.AppendText(targetPath))
  {
    foreach (Product p in productSolded)
    {
      ws.WriteLine(p.Name + "," + p.TotalSold().ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}

catch (IOException e)
{
  Console.WriteLine("An error occurred");
  Console.WriteLine(e.Message);
}
