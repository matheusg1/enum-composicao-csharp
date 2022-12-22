using HerancaComposicao.Entities;
using HerancaComposicao.Enums;
using System;

namespace HerancaComposicao
{
    public class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Client("Alex Green", "alex@g.com", (DateTime.Parse("15/03/1985")));
            var o1 = new Order((Enum.Parse<OrderStatus>("Processing")), c1);

            var p1 = new Product("TV", 1000d);
            var p2 = new Product("Mouse", 40d);

            var oi1 = new OrderItem(1, p1.Price, p1);
           
            var oi2= new OrderItem(2, p2.Price, p2);

            o1.AddItem(oi1);
            o1.AddItem(oi2);

            Console.WriteLine(o1);
        }
    }
}
