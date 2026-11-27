using SaleStockAnalyzer.Models;

namespace SaleStockAnalyzer.Services.Interfaces
{
    public interface IMostProfitableProductService
    {
        void ShowMostProfitableProduct(ProductsModel products);
    }
}
