using SaleStockAnalyzer.Infrastructure;
using SaleStockAnalyzer.Models;
using SaleStockAnalyzer.Services.Interfaces;
using System.ComponentModel.Composition;
using System.Xml.Linq;

namespace SaleStockAnalyzer.Services
{
    [Export(typeof(IDeduplicationService))]
    public class DeduplicationService : IDeduplicationService
    {
        public ProductsModel FilterProductsByModificationDate(ProductsModel products)
        {
            var groupById = products.Products
                .GroupBy(x => x.Id);

            var filterByDuplicateModificationDate = groupById
                .Where(g => g.Select(x => x.ModificationDate).Distinct().Count() < g.Count())
                .ToList();

            if (filterByDuplicateModificationDate.Any())
            {
                Console.WriteLine("Aqui");
            }

            var result = groupById
                .Select(x => x.MaxBy(product => product.ModificationDate))
                .ToList();

            return new ProductsModel
            {
                Products = result
            };
        }
    }
}