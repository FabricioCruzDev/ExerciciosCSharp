
namespace ExercicioInterfaces.Services
{
  public class PaypalService : IOnlinePaymentService
  {
    public double PaymentFee(double amount)
    {
      return amount + (amount * 0.02);
    }

    public double Interest(double amount, int months)
    {
      return amount + (amount * (months * 0.01));
    }
  }

}