using Purchase_system.Dbcontext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase_system.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public Receipt? Receipt { get; set; }

        public static void ShowProducts(int CategoryIdChoice)
        {
            Console.WriteLine("===============(Products)================");
            using Context context = new Context();
            var ChoosedCategoryProducts = context.Products
                .Where(P => P.CategoryId == CategoryIdChoice && P.Receipt == null);

            foreach (var Product in ChoosedCategoryProducts)
            {
                Console.WriteLine($"Id: {Product.Id} - {Product.Name}");
                Console.WriteLine($"Price: {Product.Price} egy");
                Console.WriteLine("*---------------------*");
            }
        }
    }
}
