using SaleStockAnalyzer.Presenter;
using SaleStockAnalyzer.Infrastructure;
using SaleStockAnalyzer.Models;

namespace SaleStockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new MenuController();
            menu.Run();

            var handler = new XmlHandler(); 
            handler.Load();
            handler.Read();
        }
    }
}