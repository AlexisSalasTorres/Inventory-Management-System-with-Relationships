using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_with_Relationships
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int productId, string name, decimal price)
        {
            ProductId = productId;
            Name = name;
            Price = price;

        }
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductId}, Name: {Name}, Price: {Price:C}");
        }
    }
}
