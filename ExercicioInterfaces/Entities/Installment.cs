namespace ExercicioInterfaces.Entities
{
  public class Installment
  {
    public DateOnly DueDate { get; set; }
    public double Amount { get; set; }

    public Installment(DateOnly dueDate, double amount)
    {
      DueDate = dueDate;
      Amount = amount;
    }
  }
}