using Purchase_system.Dbcontext;
using Purchase_system.Models;

namespace Purchase_system
{
    internal class Program
    {
        static void Main()
        {
            /*
                I am currently learning Entity Framework and have not yet begun studying MVC or APIs. As a result,
                I have developed this simple system as a console application based on my current understanding.
            */

            StaticData.GenerateData();
            using Context context = new Context();

            Account account = context.Accounts.First();

            List<Product> Cart = new List<Product>();

            Category.ShowCategories();
            int CategoryIdChoice = Category.ReadCategoryChoice();

            Product.ShowProducts(CategoryIdChoice);

            account.BuyingMode(in Cart, CategoryIdChoice);

            Receipt.ShowReceipt(in Cart);

            Console.Write("Press any button to confirm the payment: ");
            Console.ReadLine();

            account.ConfirmPayment(in Cart);

            Console.WriteLine("Thank you for using the Purshase System!");
        }
    }
}
