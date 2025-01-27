using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_with_Relationships
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Laptop", 1200.00m);
            Product product2 = new Product(2, "Mouse", 25.00m);
            Product product3 = new Product(3, "Keyboard", 75.00m);

            Order order = new Order(1001);

            order.AddOrderItem(new OrderItem(product1, 1));
            order.AddOrderItem(new OrderItem(product2, 2));
            order.AddOrderItem(new OrderItem(product3, 1));
        
            decimal totalBeforeDiscount = order.CalculateTotal();
            if (totalBeforeDiscount > 1000)
            {
                
            }
            order.DisplayOrderDetails();
        }
    }
}
