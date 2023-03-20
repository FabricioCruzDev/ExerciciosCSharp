Console.WriteLine("Digite o valor de N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("\nDigite o valor de M: ");
int m = int.Parse(Console.ReadLine());

int[,] mat = new int[n, m];

for (int i = 0; i < n; i++)
{
  Console.WriteLine($"Digite os valores da {i + 1}º linha");
  string[] values = Console.ReadLine().Split(" ");
  for (int j = 0; j < m; j++)
  {
    mat[i, j] = int.Parse(values[j]);
  }
}

for (int i = 0; i < n; i++)
{
  for (int j = 0; j < m; j++)
  {
    Console.Write(mat[i, j] + " ");
  }
  Console.WriteLine();
}

Console.Write("\nDigite um número inteiro pertencente a matriz: ");
int userNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
  for (int j = 0; j < m; j++)
  {
    if (mat[i, j] == userNumber)
    {
      Console.WriteLine("Position " + i + ", " + j);
      if (j > 0)
      {
        Console.WriteLine("Left: " + mat[i, j - 1]);
      }
      if (i > 0)
      {
        Console.WriteLine("Up: " + mat[i - 1, j]);
      }
      if (j < m - 1)
      {
        Console.WriteLine("Right: " + mat[i, j + 1]);
      }
      if (i < n - 1)
      {
        Console.WriteLine("Down: " + mat[i + 1, j]);
      }
    }
  }
}
