using SaleStockAnalyzer.Models;
using SaleStockAnalyzer.Services.Interfaces;
using System.ComponentModel.Composition;

namespace SaleStockAnalyzer.Services
{
    [Export(typeof(ITotalSalesValueOfProductsInStockService))]
    public class TotalSalesValueOfProductsInStockService : ITotalSalesValueOfProductsInStockService
    {
        public void ShowTotalSalesValueOfProductsInStock(ProductsModel products)
        {
            double totalSalesValueOfProductsInStock = GetTotalSalesValueOfProductsInStock(products);
            string title = "\n=========== Total value of products in stock ===========\n";

            Console.WriteLine(title);
            Console.WriteLine($"Total value of products in stock: {totalSalesValueOfProductsInStock}\n");
        }

        private double GetTotalSalesValueOfProductsInStock(ProductsModel products)
        {
            double totalSalesValue = 0;

            foreach (ProductModel productModel in products.Products)
            {
                double price = productModel.Details!.Price;
                int stockQuantity = productModel.SalesInformation!.InStockQuantity;

                totalSalesValue += price * stockQuantity;
            }

            return totalSalesValue;
        }
    }
}