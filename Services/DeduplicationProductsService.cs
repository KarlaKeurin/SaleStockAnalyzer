using SaleStockAnalyzer.Infrastructure;
using SaleStockAnalyzer.Models;
using SaleStockAnalyzer.Services.Interfaces;
using System.ComponentModel.Composition;

namespace SaleStockAnalyzer.Services
{
    [Export(typeof(IDeduplicationProductsService))]
    public class DeduplicationProductsService : IDeduplicationProductsService
    {
        public ProductsModel RemoveDuplicatedProducts(ProductsModel products)
        {
            List<ProductModel> productsList = new List<ProductModel>();

            foreach (var product in products.Products)
            {
                var duplicateId = false;

                for (int i = 0; i < productsList.Count; i++)
                {
                    if (product.Id == productsList[i].Id)
                    {
                        duplicateId = true;

                        if (product.ModificationDate > productsList[i].ModificationDate)
                        {
                            productsList[i] = product;
                        }
                    }
                }

                if (!duplicateId)
                {
                    productsList.Add(product);
                }
            }

            return new ProductsModel
            {
                Products = productsList
            };
        }
    }
}