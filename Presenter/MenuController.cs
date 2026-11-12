using SaleStockAnalyzer.Models;
using SaleStockAnalyzer.Services;

namespace SaleStockAnalyzer.Presenter
{
    public class MenuController
    {
        public static void ReportGeneration(ProductsModel products)
        {
            Console.Write("Choose an option: ");
            var option = Console.ReadLine();

            //TODO: Code to refect in the future
            BestSellingProductService bestSellingProduct = new BestSellingProductService();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Quantity of products in stock");
                    break;
                case "2":
                    Console.WriteLine("Total sales value of products in stock\r");
                    break;
                case "3":
                    bestSellingProduct.ShowBestSellingProduct(products);
                    break;
                case "4":
                    Console.WriteLine("Most profitable product\r");
                    break;
                case "5":
                    Console.WriteLine("Products that have not been sold\r");
                    break;
                case "6":
                    Console.WriteLine("Out-of-stock products\r");
                    break;
                case "7":
                    Console.WriteLine("Execute all options\r");
                    break;
                case "8":
                    Console.WriteLine("Exit\n");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}