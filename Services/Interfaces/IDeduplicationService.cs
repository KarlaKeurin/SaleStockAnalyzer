using SaleStockAnalyzer.Models;

namespace SaleStockAnalyzer.Services.Interfaces
{
    public interface IDeduplicationService
    {
        ProductsModel FilterProductsByModificationDate(ProductsModel products);
    }
}