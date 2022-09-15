// See https://aka.ms/new-console-template for more information
//Verificador de senhas
int senha = 2002;
bool acesso = false;
while (acesso == false)
{
  Console.WriteLine("Digite a senha de acesso: \n");
  if (int.Parse(Console.ReadLine()) == senha)
  {
    Console.WriteLine("Acesso Liberado");
    acesso = true;
  }
  else
    Console.WriteLine("Acesso Negado");
}
