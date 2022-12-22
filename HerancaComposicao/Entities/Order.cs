using HerancaComposicao.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaComposicao.Entities
{
    public class Order
    {

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        
        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
            Moment = DateTime.Now;
        }

        public Order()
        {
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double valorTotal = 0;
            foreach(OrderItem item in Items)
            {
                valorTotal += item.Price;
            }
            return valorTotal;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");
            foreach(OrderItem item in Items)
            {
                sb.Append(item.ToString());
                sb.Append(", Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", Subtotal: $");
                sb.Append(item.SubTotal());
                sb.AppendLine();
            }
            sb.Append("Total price: $");
            sb.Append(Total().ToString("F2", CultureInfo.CurrentCulture));
            return sb.ToString();
        }
    }
}
