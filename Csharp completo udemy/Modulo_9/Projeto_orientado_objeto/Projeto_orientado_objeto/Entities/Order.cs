using System;
using System.Collections.Generic;
using Projeto_orientado_objeto.Entities.Enum;
using System.Text;
namespace Projeto_orientado_objeto.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }
        public void RemoveOrderItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem orderItem in Items)
            {
                sum += orderItem.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();         
            sb.AppendLine("Order momment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));
            return sb.ToString();
        }
    }
}
