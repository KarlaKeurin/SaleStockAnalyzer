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
            decimal totalSalesValueOfProductsInStock = GetTotalSalesValueOfProductsInStock(products);

            Console.WriteLine($"\nTotal value of products in stock: {totalSalesValueOfProductsInStock}\n");
        }

        private decimal GetTotalSalesValueOfProductsInStock(ProductsModel products)
        {
            decimal totalSalesValue = 0;

            foreach (ProductModel productModel in products.Products)
            {
                decimal price = productModel.Details!.Price;
                int stockQuantity = productModel.SalesInformation!.InStockQuantity;

                totalSalesValue += price * stockQuantity;
            }

            return totalSalesValue;
        }
    }
}