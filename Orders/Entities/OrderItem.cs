using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.Entities
{
  public class OrderItem
  {
    public int Quantity { get; set; }
    public double Price { get; set; }

    public OrderItem()
    {

    }

    public OrderItem(int quantity, double price)
    {
      Quantity = quantity;
      Price = price;
    }

    public double Total()
    {
      return Quantity * Price;
    }
  }
}