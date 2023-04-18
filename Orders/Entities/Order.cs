using System;
using System.Collections.Generic;
using Orders.Entities.Enums;

namespace Orders.Entities
{
  public class Order
  {
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    public Order()
    {

    }

    public void AddItem(OrderItem item)
    {

    }
    public void RemoveItem(OrderItem item)
    {

    }

    public double Total()
    {
      return 0.00; // provisório
    }
  }
}