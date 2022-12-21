using HerancaComposicao.Entities;
using HerancaComposicao.Enums;
using System;

namespace HerancaComposicao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Enums.OrderStatus.Delivered
            };
            Console.WriteLine(order);

            //Conversão de enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Conversão de string para enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
