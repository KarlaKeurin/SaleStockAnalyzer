using SaleStockAnalyzer.Presenter;
using SaleStockAnalyzer.Infrastructure;
using SaleStockAnalyzer.Models;

namespace SaleStockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuOptions = new MenuOptions();
            menuOptions.ShowMenu();

            var menu = new MenuController();
            MenuController.ReportGeneration();

            var handler = new XmlHandler(); 
            handler.Load();
            handler.GetProducts();
        }
    }
}