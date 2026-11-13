namespace SaleStockAnalyzer.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DetailsModel? Details { get; set; }
        public SalesInformationModel? SalesInformation { get; set; }
        public DateTime ModificationDate { get; set; }

        public override string ToString()
        {
            return $"""
                Id: {Id}
                Name: {Name}
                Sold Quantity: {SalesInformation.SoldQuantity}
                In Stock Quantity: {SalesInformation.InStockQuantity}
                Description: {Details.Description.Trim()}
                Price: {Details.Price}
                Modification Date: {ModificationDate:dd-MM-yyyy HH:mm:ss}
                """;
        }
    }
}