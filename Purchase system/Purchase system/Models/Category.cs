using Purchase_system.Dbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase_system.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public static void ShowCategories()
        {
            using Context context = new Context();

            var Categories = context.Categories;
            Console.WriteLine("==============(Categories)==============");
            foreach (var C in Categories)
                Console.WriteLine($"Id:{C.Id} - {C.Name}");
        }
        public static int ReadCategoryChoice()
        {
            using Context context = new Context();
            HashSet<int> CategoriesIds = context.Categories.Select(C => C.Id).ToHashSet();
            int Choice;
            bool Valid;
            do
            {
                Console.Write("Enter your choice: ");
                Valid = int.TryParse(Console.ReadLine(), out Choice);
            }
            while (!Valid || !CategoriesIds.Contains(Choice));
            return Choice;
        }
    }
}
