using SaleStockAnalyzer.Models;
using SaleStockAnalyzer.Services.Interfaces;
using System.ComponentModel.Composition;
using SaleStockAnalyzer.Enum;

namespace SaleStockAnalyzer.Controller
{
    public class ReportController
    {
        [Import]
        public IBestSellingProductService BestSellingProduct { get; set; }

        public void ReportGeneration(ProductsModel products, int option)
        {
            switch ((MenuOptionsEnum)option)
            {
                case MenuOptionsEnum.BestSellingProduct:
                    BestSellingProduct.ShowBestSellingProduct(products);
                    break;

                case MenuOptionsEnum.QuantityOfProductsInStock:
                case MenuOptionsEnum.TotalSalesValueOfProductsInStock:
                case MenuOptionsEnum.MostProfitableProduct:
                case MenuOptionsEnum.ProductsThatHaveNotBeenSold:
                case MenuOptionsEnum.OutOfStockProducts:
                case MenuOptionsEnum.ExecuteAllOptions:
                    Console.WriteLine("\nReport Not Implemented Yet");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}