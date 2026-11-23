using SaleStockAnalyzer.Presenter;
using SaleStockAnalyzer.Infrastructure;
using SaleStockAnalyzer.Models;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;
using SaleStockAnalyzer.Controller;
using SaleStockAnalyzer.Services;

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

            var option = MenuOptions.ShowMenu();

            var handler = new XmlHandler(); 
            handler.Load();
            var productsXml = handler.GetProducts();

            var productsListDeduplicated = new DeduplicationService();
            var products = productsListDeduplicated.FilterProductsByModificationDate(productsXml);

            reportController.ReportGeneration(products, option);
        }
    }
}