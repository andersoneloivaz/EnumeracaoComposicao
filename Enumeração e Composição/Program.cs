using Enumeração_e_Composição.Entities;
using Enumeração_e_Composição.Entities.Enums;
using System;

namespace Enumeração_e_Composição
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Entities.Enums.OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);

            
        }
    }
}
