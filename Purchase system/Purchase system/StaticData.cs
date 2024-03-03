using Purchase_system.Dbcontext;
using Purchase_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase_system
{
    internal static class StaticData
    {
        public static void GenerateData()
        {
            GenerateAccounts();
            GenerateCategories();
            GenerateProducts();
        }
        private static void GenerateAccounts()
        {
            using Context context = new Context();

            context.Accounts.Add(new Account
            {
                Name = "Yousef",
                Email = "Yousef@gmail.com",
                Password = "Pass123",
                PhoneNumber = "1234567890",
                Receipts = null,
                Balance = 100_000
            });

            context.Accounts.Add(new Account
            {
                Name = "Omar",
                Email = "Omar@gmail.com",
                Password = "Pass123",
                PhoneNumber = "1234567890",
                Receipts = null,
                Balance = 500_000
            });
            context.SaveChanges();
        }
        private static void GenerateCategories()
        {
            using Context context = new Context();

            context.Categories.Add(new Category
            {
                Name = "Mobile",
            });
            context.Categories.Add(new Category
            {
                Name = "TV",
            });
            context.Categories.Add(new Category
            {
                Name = "Watch",
            });

            context.SaveChanges();
        }
        private static void GenerateProducts()
        {
            using Context context = new Context();

            context.Products.Add(new Product
            {
                Name = "Iphone",
                CategoryId = 1,
                Price = 35000,
                ProductionDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            });

            context.Products.Add(new Product
            {
                Name = "Iphone",
                CategoryId = 1,
                Price = 35000,
                ProductionDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            });

            context.Products.Add(new Product
            {
                Name = "Oppo",
                CategoryId = 1,
                Price = 15000,
                ProductionDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            });
            context.Products.Add(new Product
            {
                Name = "Oppo",
                CategoryId = 1,
                Price = 15000,
                ProductionDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            });

            context.Products.Add(new Product
            {
                Name = "Samsung Tv",
                CategoryId = 2,
                Price = 30000,
                ProductionDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            });

            context.Products.Add(new Product
            {
                Name = "Samsung Tv",
                CategoryId = 2,
                Price = 30000,
                ProductionDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            });

            context.Products.Add(new Product
            {
                Name = "LG Tv",
                CategoryId = 2,
                Price = 25000,
                ProductionDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            });

            context.Products.Add(new Product
            {
                Name = "LG Tv",
                CategoryId = 2,
                Price = 25000,
                ProductionDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            });

            context.Products.Add(new Product
            {
                Name = "Apple Watch",
                CategoryId = 3,
                Price = 25000,
                ProductionDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            });

            context.Products.Add(new Product
            {
                Name = "Apple Watch",
                CategoryId = 3,
                Price = 25000,
                ProductionDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            });

            context.Products.Add(new Product
            {
                Name = "Orimo Watch",
                CategoryId = 3,
                Price = 3000,
                ProductionDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            });

            context.Products.Add(new Product
            {
                Name = "Orimo Watch",
                CategoryId = 3,
                Price = 3000,
                ProductionDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            });
            context.SaveChanges();
        }
    }
}
