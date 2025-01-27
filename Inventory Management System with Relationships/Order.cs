using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_with_Relationships
{
    class Order
    {
        public int OrderId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public decimal Discount { get; set; }

        public Order(int orderId)

        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
            Discount = 0;
        }
        public void AddOrderItem(OrderItem item)
        {
            OrderItems.Add(item);
        }
        public decimal CalculateTotal()
        {


            decimal total = 0;
            foreach (var item in OrderItems)
            {
                total += item.GetTotalPrice();
            }
            return total * (1 - Discount / 100);
        }
        public void DisplayOrderDetails()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            foreach (var item in OrderItems)
            {
                Console.WriteLine($"- {item.Product.Name}, Quantity: {item.Quantity}, Total: {item.GetTotalPrice():C}");

                Console.WriteLine($"Total Order Value: {CalculateTotal():C}");
            }

        }
        public void ApplyDiscount(decimal discountPercentage)
        {

            if (discountPercentage >= 0 && discountPercentage <= 100)

                Discount = discountPercentage;

            else

                Console.WriteLine("Invalid discount percentage.");
            Console.ReadLine();


        }     

    }
}
        
    
