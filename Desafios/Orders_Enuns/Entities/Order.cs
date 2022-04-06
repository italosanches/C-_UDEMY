using Orders_Enuns.Entities.Enuns;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Enuns.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItem.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem order in OrderItem)
            {
                sum += order.SubTotal();
            }
            return sum;

        }

        public override string ToString()
        {
          StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("G"));
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine("Client: " + Client.ToString());
            sb.AppendLine("Order itens: ");
            foreach (OrderItem order in OrderItem)
            {
                sb.AppendLine(order.ToString());
            }
            sb.AppendLine("Total Price: $" + Total().ToString("F2",CultureInfo.InvariantCulture));

            return sb.ToString();
         }
    }
}
