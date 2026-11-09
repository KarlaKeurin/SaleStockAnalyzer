using System.Globalization;
using System.Xml.Linq;
using SaleStockAnalyzer.Models;

namespace SaleStockAnalyzer.Infrastructure
{
    public class XmlHandler
    {
        public XDocument Load()
        {
            var filePath = Path.Combine(AppContext.BaseDirectory, "Sales_Stock.xml");

            return XDocument.Load(filePath);
        }

        public void Read()
        {
            var doc = Load();

            var products = new ProductsModel();

            foreach (var element in doc.Root.Elements("Product"))
            {
                var product = new ProductModel
                {
                    Id = (int)element.Attribute("id"),
                    Name = (string)element.Element("Name"),

                    Details = new DetailsModel
                    {
                        Description = (string)element.Element("Details").Element("Description"),
                        Price = (double)element.Element("Details").Element("Price")
                    },

                    SalesInformation = new SalesInformationModel
                    {
                        InStockQuantity = (int)element.Element("SalesInformation").Element("InStockQuantity"),
                        SoldQuantity = (int)element.Element("SalesInformation").Element("SoldQuantity")
                    },

                    ModificationDate = DateTime.ParseExact(
                        (string)element.Element("ModificationDate"),
                        "yyyyMMdd'T'HHmmss",
                        CultureInfo.InvariantCulture
                        )
                };

                products.Products.Add(product);
            }
        }
    }
}