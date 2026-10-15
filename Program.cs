using SaleStockAnalyzer.Controllers;

namespace SaleStockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuController menuController = new MenuController();
            menuController.ShowMenu();
        }
    }
}
