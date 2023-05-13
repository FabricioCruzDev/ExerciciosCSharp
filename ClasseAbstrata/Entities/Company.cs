namespace ClasseAbstrata.Entities
{
  class Company : Payer
  {
    public int Number_employees { get; set; }

    public Company(string name, double anual_income, int number_employees)
    : base(name, anual_income)
    {
      Number_employees = number_employees;
    }

    public sealed override double TaxPaid()
    {
      if (Number_employees <= 10)
        return Anual_income * 0.16;
      else
        return Anual_income * 0.14;
    }
  }
}