using SaleStockAnalyzer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleStockAnalyzer.Services.Interfaces
{
    public interface ITotalSalesValueOfProductsInStockService
    {
        void ShowTotalSalesValueOfProductsInStock(ProductsModel products);
    }
}