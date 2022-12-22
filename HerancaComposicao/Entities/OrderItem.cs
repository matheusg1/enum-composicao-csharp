using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaComposicao.Entities
{
    public class OrderItem
    {

        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Product.Name);
            sb.Append(", ");
            sb.Append(Price.ToString("F2", CultureInfo.CurrentCulture));
            return sb.ToString();
        }
    }
}
