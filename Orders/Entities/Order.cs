using Orders.Entities.Enums;
using System.Text;
using System.Globalization;

namespace Orders.Entities
{
  public class Order
  {
    public DateTime Moment { get; private set; }
    public OrderStatus Status { get; set; }
    public List<OrderItem> Item { get; private set; } = new List<OrderItem>();
    public Client OrderClient { get; set; } = new Client();

    public Order()
    {

    }

    public Order(DateTime moment, OrderStatus status, Client orderCliente)
    {
      Moment = moment;
      Status = status;
      OrderClient = orderCliente;
    }

    public void AddItem(OrderItem item)
    {
      Item.Add(item);
    }
    public void RemoveItem(OrderItem item)
    {
      Item.Remove(item);
    }

    public double Total()
    {
      double sum = 0.0;
      foreach (OrderItem item in Item)
      {
        sum += item.Subtotal();
      }
      return sum;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("Order momment: ");
      sb.AppendLine(Moment.ToString("dd/MM/yyyy HH/mm/ss"));
      sb.Append("Order status: ");
      sb.AppendLine(Status.ToString());
      sb.Append("Client: ");
      sb.AppendLine(OrderClient.ToString());
      sb.AppendLine("Order items:");
      foreach (OrderItem item in Item)
      {
        sb.AppendLine(item.ToString());
      }
      sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
      return sb.ToString();
    }
  }
}