using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_with_Relationships
{
    class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public decimal GetTotalPrice()
        {
            return Product.Price * Quantity;
        }
    }
}
