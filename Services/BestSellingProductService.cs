using SaleStockAnalyzer.Models;

namespace SaleStockAnalyzer.Services
{
    public class BestSellingProductService
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