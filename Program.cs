using SaleStockAnalyzer.Controller;
using SaleStockAnalyzer.Enum;
using SaleStockAnalyzer.Infrastructure;
using SaleStockAnalyzer.Models;
using SaleStockAnalyzer.Presenter;
using SaleStockAnalyzer.Services;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace SaleStockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inatializes MEF
            using var catalog = new AssemblyCatalog(typeof(ReportController).Assembly);
            var container = new CompositionContainer(catalog);
            var reportController = new ReportController();
            container.ComposeParts(reportController);

            MenuOptionsEnum menuEnum;

            do
            {
                var option = MenuOptions.ShowMenu();
                menuEnum = (MenuOptionsEnum)option;

                var handler = new XmlHandler(); 
                handler.Load();

                Console.Clear();

                var productsXml = handler.GetProducts();
                var productsListDeduplicated = new DeduplicationProductsService();
                var products = productsListDeduplicated.RemoveDuplicatedProducts(productsXml);
                
                reportController.ReportGeneration(products, option);

                if (menuEnum != MenuOptionsEnum.Exit)
                {
                    Console.WriteLine("\nPress any key to return to the menu options...");
                    Console.ReadKey();
                }

                Console.Clear();
            } while (menuEnum != MenuOptionsEnum.Exit);
        }
    }
}