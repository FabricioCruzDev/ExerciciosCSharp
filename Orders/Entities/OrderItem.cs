using System.Globalization;

namespace Orders.Entities
{
  public class OrderItem
  {
    public int Quantity { get; set; }
    public double Price { get; set; }
    public Product ProductName { get; set; }

    public OrderItem()
    {

    }

    public OrderItem(int quantity, double price, Product productName)
    {
      Quantity = quantity;
      Price = price;
      ProductName = productName;
    }

    public double Subtotal()
    {
      return Quantity * Price;
    }

    public override string ToString()
    {
      return ProductName.Name
             + ", $"
             + Price.ToString("F2", CultureInfo.InvariantCulture)
             + ", Quantity: "
             + Quantity
             + ", Subtotal: $"
             + Subtotal().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}