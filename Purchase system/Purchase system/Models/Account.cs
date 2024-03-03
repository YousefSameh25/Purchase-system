using Purchase_system.Dbcontext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase_system.Models
{
    internal class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public decimal Balance { get; set; } = 0;

        public ICollection<Receipt>? Receipts { get; set; } = new HashSet<Receipt>();

        public void BuyingMode(in List<Product> Cart, int CategoryId)
        {
            Console.WriteLine("==================(Buying mode)=================");
            decimal balance = Balance;
            using Context context = new Context();
            HashSet<int> AddedProductsId = new HashSet<int>();
            var ProductsId = context.Products
                                    .Where(P => P.CategoryId == CategoryId && P.Receipt == null)
                                    .Select(P => P.Id)
                                    .ToHashSet();
            bool Exit = false, Valid;
            do
            {
                Console.Write("Enter the product Id or '0' to exit buying mode: ");
                int Id;
                Valid = int.TryParse(Console.ReadLine(), out Id);
                if (Valid)
                {
                    if (Id == 0)
                        Exit = true;
                    else
                    {
                        if (AddedProductsId.Contains(Id))
                            Console.WriteLine("The product is already exist in your cart!");
                        else
                        {
                            if (ProductsId.Contains(Id))
                            {
                                decimal ProductPrice = context.Products.Single(P => P.Id == Id).Price;
                                if (balance >= ProductPrice)
                                {
                                    Console.WriteLine("Product has been added successfully!");
                                    AddedProductsId.Add(Id);
                                    Cart.Add(context.Products.Single(P => P.Id == Id));
                                    balance -= ProductPrice;
                                }
                                else
                                {
                                    Console.WriteLine("Oops your balance is not sufficient!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid product id!");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product id!");
                }
            }
            while (!Exit);
            Console.WriteLine("Exiting buying mode....");
        }

        public void ConfirmPayment(in List<Product> cart)
        {
            using Context context = new Context();

            Receipt receipt = new Receipt();

            var account = context.Accounts.Single(A => A.Id == Id);
            decimal TotalPrice = 0;
            foreach (var Product in cart)
            {
                receipt.Products.Add(context.Products.Single(P => P.Id == Product.Id));
                TotalPrice += Product.Price;
            }
            receipt.TotalPrice = TotalPrice;
            receipt.AccountId = account.Id;

            context.Receipts.Add(receipt);

            account.Balance -= TotalPrice;
            Console.WriteLine($"Your balance: {account.Balance}");
            Console.WriteLine("============================================");
            context.SaveChanges();
        }
    }
}