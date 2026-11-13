using SaleStockAnalyzer.Models;
using SaleStockAnalyzer.Services.Interfaces;
using System.ComponentModel.Composition;

namespace SaleStockAnalyzer.Services
{
    [Export(typeof(IBestSellingProductService))]
    public class BestSellingProductService : IBestSellingProductService
    {
        public void ShowBestSellingProduct(ProductsModel products)
        {
            ProductModel bestSellingProduct = GetBestSellingProduct(products);

            Console.WriteLine(bestSellingProduct);
        }

        private ProductModel GetBestSellingProduct(ProductsModel products)
        {
            ProductModel bestSellingProduct = null;
            int highestSoldQuantity = 0;

            foreach (ProductModel product in products.Products)
            {
                int soldQuantity = product.SalesInformation.SoldQuantity;

                if (bestSellingProduct == null || soldQuantity > highestSoldQuantity)
                {
                    highestSoldQuantity = soldQuantity;
                    bestSellingProduct = product;
                }
            }

            return bestSellingProduct;
        }
    }
}