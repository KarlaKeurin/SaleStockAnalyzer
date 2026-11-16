using System.ComponentModel.Composition;
using SaleStockAnalyzer.Models;
using SaleStockAnalyzer.Services.Interfaces;

namespace SaleStockAnalyzer.Services
{
    [Export(typeof(IQuantityOfProductsInStockService))]
    public class QuantityOfProductsInStockService : IQuantityOfProductsInStockService
    {
        public void ShowQuantityOfProductsInStockService(ProductsModel products)
        {
            int quantityOfProductsInStock = GetQuantityOfProductsInStock(products);
            
            Console.WriteLine($"\nQuantity of products in stock: {quantityOfProductsInStock}\n");
        }

        private int GetQuantityOfProductsInStock(ProductsModel products)
        {
            int inStockQuantity = 0;


            foreach (ProductModel product in products.Products)
            {
                int inStock = product.SalesInformation!.InStockQuantity;

                inStockQuantity += inStock;
            }

            return inStockQuantity;
        }
    }
}