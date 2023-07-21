using System.IO;

Dictionary<string, int> ballotCount = new Dictionary<string, int>();

Console.WriteLine("Enter file full path: ");
string path = Console.ReadLine();

try
{
  using (StreamReader rs = new StreamReader(path))
  {
    while (!rs.EndOfStream)
    {
      string[] line = rs.ReadLine().Split(",");
      if (!(ballotCount.ContainsKey(line[0])))
      {
        ballotCount[line[0]] = int.Parse(line[1]);
      } else ballotCount[line[0]] += int.Parse(line[1]);
    }

    Console.WriteLine("RESULT");

    foreach (KeyValuePair<string, int> item in ballotCount)
    {
      Console.WriteLine(item.Key + ": " + item.Value);
    }
  }
}
catch (IOException e)
{
  Console.WriteLine("File error!", e.Message);
}