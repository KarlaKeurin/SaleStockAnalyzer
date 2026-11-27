using SaleStockAnalyzer.Models;
using SaleStockAnalyzer.Services.Interfaces;
using System.ComponentModel.Composition;

namespace SaleStockAnalyzer.Services
{
    [Export(typeof(IMostProfitableProductService))]
    public class MostProfitableProductService : IMostProfitableProductService
    {
        public void ShowMostProfitableProduct(ProductsModel products)
        {
            ProductModel mostProfitableProduct = GetMostProfitableProduct(products);

            Console.WriteLine("\n=========== Most profitable product ===========\n");
            Console.WriteLine(mostProfitableProduct);
        }

        private ProductModel GetMostProfitableProduct(ProductsModel products)
        {
            ProductModel mostProfitableProduct = null;
            decimal highestProfitability = 0;

            foreach (ProductModel product in products.Products)
            {
                int soldQuantity = product.SalesInformation!.SoldQuantity;
                decimal price = product.Details!.Price;
                decimal profitability = soldQuantity * price;

                if (profitability > highestProfitability)
                {
                    highestProfitability = profitability;
                    mostProfitableProduct = product;
                }
            }

            return mostProfitableProduct;
        }
    }
}