namespace ClasseAbstrata.Entities
{
  class Individual : Payer
  {
    public double Health_expenditures { get; set; }

    public Individual(string name, double anual_income, double health_expenditures)
    : base(name, anual_income)
    {
      Health_expenditures = health_expenditures;
    }

    public sealed override double TaxPaid()
    {
      if (Anual_income < 20000.00)
        return (Anual_income * 0.15) - (Health_expenditures * 0.5);
      else
        return (Anual_income * 0.25) - (Health_expenditures * 0.5);
    }
  }
}