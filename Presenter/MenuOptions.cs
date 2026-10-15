namespace SaleStockAnalyzer.Presenter
{
    public class MenuOptions
    {
        public void ShowMenu()
        {
            Console.WriteLine("=========== Sale Stock Analyzer ===========\n");

            Console.WriteLine("1 - Quantity of products in stock");
            Console.WriteLine("2 - Total sales value of products in stock\r");
            Console.WriteLine("3 - Best-selling product\r");
            Console.WriteLine("4 - Most profitable product\r");
            Console.WriteLine("5 - Products that have not been sold\r");
            Console.WriteLine("6 - Out-of-stock products\r");
            Console.WriteLine("7 - Execute all options\r");
            Console.WriteLine("8 - Exit\n");

            Console.Write("Choose an option: ");
            var option = Console.ReadLine();

            Console.WriteLine(option);
        }
    }
}
