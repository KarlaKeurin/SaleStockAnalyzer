using SaleStockAnalyzer.Models;

namespace SaleStockAnalyzer.Services.Interfaces
{
    public interface IDeduplicationProductsService
    {
        ProductsModel RemoveDuplicatedProducts(ProductsModel products);
    }
}