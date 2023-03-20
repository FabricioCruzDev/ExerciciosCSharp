namespace ExercicioFixacao4
{
  public class ConversorDeMoeda
  {
    public static double Iof = 6;

    public static double DolarParaReal(double quantidade, double cotacao)
    {
      double total = quantidade * cotacao;
      return total + total * Iof / 100.0;
    }
  }
}