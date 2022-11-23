using Exercicio_de_fixação.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_fixação.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItens { get; set; }
        public Client Cliente { get; set; }


        public Order(OrderStatus status, Client cliente)
        {        
            Status = status; 
            Cliente = cliente;
            OrderItens = new List<OrderItem>();
            
            
        }

        public Order()
        {
            
        }

        public void AddItem(OrderItem item)
        {
            OrderItens.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItens.Remove(item);
        }

        public double Total()
        {
            double result = 0;

            foreach (OrderItem item in OrderItens) {
                result += item.Subtotal();
            
            }  
            return result;

         }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            
            text.AppendLine("ORDER SUMMARY: ");
            text.Append("Order Moment: ");
            text.AppendLine(Moment.ToString("dd/MM/yyyy hh:mm:ss"));
            text.Append("Order Status: ");
            text.AppendLine(Status.ToString());
            text.Append("Client: ");
            text.Append(Cliente.Name + " ");
            text.Append($"({Cliente.BirthDate.ToString("dd/MM/yyyy")}) - ");
            text.AppendLine(Cliente.Email);

            text.AppendLine("Order Items: ");
            
            foreach (OrderItem item in OrderItens) {
             text.Append(item.ToString());
            
            }

            return text.ToString();




        }


    }
}
