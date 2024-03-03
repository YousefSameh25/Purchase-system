using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase_system.Models
{
    internal class Receipt
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PaymentTime { get; set; }

        [ForeignKey("AccountId")]
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();

        public static void ShowReceipt(in List<Product> Cart)
        {
            Console.WriteLine("==================(Your Receipt)==================");
            decimal TotalPrice = 0;
            int i = 1;
            foreach (var item in Cart)
            {
                Console.WriteLine($"*Item({i++})*");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Price: {item.Price}");
                TotalPrice += item.Price;
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Total price: {TotalPrice}");
            Console.WriteLine("=================================================");
        }
    }
}
