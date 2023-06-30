using ExercicioInterfaces.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioInterfaces.Services
{
  public class ContractService
  {
    private IOnlinePaymentService _onlinePaymentService;

    public ContractService(IOnlinePaymentService onlinePaymentService)
    {
      _onlinePaymentService = onlinePaymentService;
    }

    public void ProcessContract(Contract contract, int months)
    {
      List<Installment> installments = new List<Installment>();
      double amount = contract.ContractValue / months;
      for (int i = 1; i <= months; i++)
      {
        double interestAmount = _onlinePaymentService.Interest(amount, i);
        double totalAmount = _onlinePaymentService.PaymentFee(interestAmount);
        installments.Add(new Installment(contract.Date.AddMonths(i), totalAmount));
      }
      foreach (Installment obj in installments)
      {
        Console.WriteLine(obj.DueDate.ToString() + " - " + obj.Amount.ToString("F2", CultureInfo.InvariantCulture));
      }
    }
  }
}