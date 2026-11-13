using SaleStockAnalyzer.Models;

namespace SaleStockAnalyzer.Services.Interfaces
{
    public interface IBestSellingProductService
    {
        void ShowBestSellingProduct(ProductsModel products);
    }
}