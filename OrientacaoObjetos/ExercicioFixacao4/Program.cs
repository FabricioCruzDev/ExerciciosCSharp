namespace ExercicioFixacao4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por"
                        + " uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda"
                        + " que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda"
                        + " para ser responsável pelos cálculos.");
      Console.Write("Qual é a cotação do dólar? ");
      double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Quantos dólares você vai comprar? ");
      double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double resultado = ConversorDeMoeda.DolarParaReal(quantidade, cotacao);


      Console.WriteLine($"Valor a ser pago em reais = R$ {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
    }
  }
}