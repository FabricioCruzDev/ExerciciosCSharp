using ExercicioArray;

Quarto[] vectQuarto = new Quarto[10];

for (int i = 0; i < 10; i++)
{
  vectQuarto[i] = new Quarto {Numero = i, Ocupado = false};
}

Console.Write("Quantos alunos vão ocupar os quartos: ");
int n = int.Parse(Console.ReadLine());

Quarto[] vectAluguel = new Quarto[n];

for (int i = 0; i < n; i++)
{
  Console.Write("Nome: ");
  string nome = Console.ReadLine();
  Console.Write("Email: ");
  string email = Console.ReadLine();
  Console.WriteLine("Quartos disponíveis: ");
  for (int q = 0; q < 10; q++)
  {
    if(!vectQuarto[q].Ocupado)
    {
      Console.Write(" " + q);
    }
  }
  Console.WriteLine();
  Console.WriteLine("Digite o número do quarto: ");
  int quartoEscolhido = int.Parse(Console.ReadLine());
  vectAluguel[i] = new Quarto (nome, email, quartoEscolhido);
  vectQuarto[quartoEscolhido].Ocupado = true;
  vectQuarto[quartoEscolhido].Hospede = nome;
  vectQuarto[quartoEscolhido].Email = nome;
}

Console.WriteLine("Quartos ocupados:");
for (int i = 0; i < 10; i++)
{
  if(vectQuarto[i].Ocupado)
  {
    Console.Write(vectQuarto[i].ToString());
  }
}

