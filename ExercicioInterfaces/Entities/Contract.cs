using System.Globalization;

namespace ExercicioInterfaces.Entities
{
  public class Contract
  {
    public int ContractNumber { get; set; }
    public DateOnly Date { get; set; }
    public double ContractValue { get; set; }

    public Contract(int contractNumber, DateOnly date, double contractValue)
    {
      ContractNumber = contractNumber;
      Date = date;
      ContractValue = contractValue;
    }
  }
}