// See https://aka.ms/new-console-template for more information
int codigo;
int quantidade;
double preco;
double total;

Console.WriteLine("Digite o código do produto: \n");
codigo = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Digite a quantidade: \n");
quantidade = Convert.ToInt16(Console.ReadLine());

switch (codigo)
{
  case 1:
    total = quantidade * 4.00;
    Console.WriteLine("total: R$" + total.ToString("N2"));
    break;

  case 2:
    total = quantidade * 4.50;
    Console.WriteLine("total: R$" + total.ToString("N2"));
    break;

  case 3:
    total = quantidade * 5.00;
    Console.WriteLine("total: R$" + total.ToString("N2"));
    break;

  case 4:
    total = quantidade * 2.00;
    Console.WriteLine("total: R$" + total.ToString("N2"));
    break;

  case 5:
    total = quantidade * 1.50;
    Console.WriteLine("total: R$" + total.ToString("N2"));
    break;
}

