using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleStockAnalyzer.Presenter
{
    public class MenuController
    {
        private readonly MenuOptions _menuOptions;
        public MenuController()
        {
            _menuOptions = new MenuOptions();
        }

        public void Run()
        {
            string option = _menuOptions.ShowMenu();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Quantity of products in stock");
                    break;
                case "2":
                    Console.WriteLine("Total sales value of products in stock\r");
                    break;
                case "3":
                    Console.WriteLine("Best-selling product\r");
                    break;
                case "4":
                    Console.WriteLine("Most profitable product\r");
                    break;
                case "5":
                    Console.WriteLine("Products that have not been sold\r");
                    break;
                case "6":
                    Console.WriteLine("Out-of-stock products\r");
                    break;
                case "7":
                    Console.WriteLine("Execute all options\r");
                    break;
                case "8":
                    Console.WriteLine("Exit\n");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}