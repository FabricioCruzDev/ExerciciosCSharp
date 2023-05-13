using System.Globalization;

namespace ClasseAbstrata.Entities
{
  abstract class Payer
  {
    public string Name { get; set; }
    public double Anual_income { get; set; }

    public Payer(string name, double anual_income)
    {
      Name = name;
      Anual_income = anual_income;
    }

    public abstract double TaxPaid();
  }
}