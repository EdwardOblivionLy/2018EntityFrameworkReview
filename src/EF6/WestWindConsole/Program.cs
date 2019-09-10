using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindConsole.DAL;
using WestWindConsole.Entities;

namespace WestWindConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Program();
            app.CheckTables();
        }

        private void CheckTables()
        {
            int menuChoice = 0;
            do
            {
                menuChoice = ChooseTable();
                switch (menuChoice)
                {
                    case 1:
                        DisplayProducts();
                        break;
                    case 2:
                        DisplayCategories();
                        break;
                    case 3:
                        DisplaySuppliers();
                        break;
                    case 4:
                        DisplayOrderDetails();
                        break;
                    case 5:
                        DisplayEmployees();
                        break;
                    case 6:
                        DisplayEmployeeTerritories();
                        break;
                    case 7:
                        DisplayShipments();
                        break;
                    case 8:
                        DisplayShippers();
                        break;
                    // TODO: Practice - Display methods for remaining tables
                    case 9:
                        DisplayRegions();
                        break;
                    case 10:
                        DisplayTerritories();
                        break;
                    case 11:
                        DisplayPaymentTypes();
                        break;
                    case 12:
                        DisplayAddresses();
                        break;
                    case 13:
                        DisplayCustomers();
                        break;
                    case 14:
                        DisplayPayments();
                        break;
                    case 15:
                        DisplayOrders();
                        break;
                    case 16:
                        DisplayManifestItems();
                        break;
                }
                Pause();
            } while (menuChoice > 0 && menuChoice <= 16);
        }

        private void Pause()
        {
            Console.WriteLine("-- Press [Enter] to continue --");
            Console.ReadLine();
            Console.Clear();
        }

        private void DisplayShippers()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Shippers.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Shippers");
            }
        }

        private void DisplayShipments()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Shipments.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Shipments");
            }
        }

        private void DisplayEmployeeTerritories()
        {
            using (var context = new WestWindContext())
            {
                int count = context.EmployeeTerritories.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Employee Territories");
            }
        }

        private void DisplayEmployees()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Employees.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Employees");
            }
        }

        private void DisplayOrderDetails()
        {
            using (var context = new WestWindContext())
            {
                int count = context.OrderDetails.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} order details");
            }
        }

        private void DisplaySuppliers()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Suppliers.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} suppliers");
            }
        }

        private void DisplayCategories()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Categories.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} categories");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                var data = context.Categories.Include(nameof(Category.Products));
                foreach (var item in data)
                {
                    Console.WriteLine($"\t{item.CategoryName} has {item.Products.Count()} products");
                }
                Console.ResetColor();
            }
        }

        private void DisplayProducts()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Products.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} products");
            }
        }

        private void DisplayRegions()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Regions.Count();
                Console.WriteLine($"There are {count} regions");
            }
        }

        private void DisplayTerritories()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Territories.Count();
                Console.WriteLine($"There are {count} territories");
            }
        }

        private void DisplayPaymentTypes()
        {
            using (var context = new WestWindContext())
            {
                int count = context.PaymentTypes.Count();
                Console.WriteLine($"There are {count} payment types");
            }
        }

        private void DisplayAddresses()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Addresses.Count();
                Console.WriteLine($"There are {count} addresses");
            }
        }

        private void DisplayCustomers()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Customers.Count();
                Console.WriteLine($"There are {count} customers");
            }
        }

        private void DisplayPayments()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Payments.Count();
                Console.WriteLine($"There are {count} payments");
            }
        }

        private void DisplayOrders()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Orders.Count();
                Console.WriteLine($"There are {count} orders");
            }
        }

        private void DisplayManifestItems()
        {
            using (var context = new WestWindContext())
            {
                int count = context.ManifestItems.Count();
                Console.WriteLine($"There are {count} manifest items");
            }
        }

        private int ChooseTable()
        {
            Console.WriteLine("1) Products");
            Console.WriteLine("2) Categories");
            Console.WriteLine("3) Suppliers");
            Console.WriteLine("4) Order Details");
            Console.WriteLine("5) Employees");
            Console.WriteLine("6) Employee Territories");
            Console.WriteLine("7) Shipments");
            Console.WriteLine("8) Shippers");
            // TODO: Practice - Menu options for remaining tables
            Console.WriteLine("9) Regions");
            Console.WriteLine("10) Territories");
            Console.WriteLine("11) Payment Types");
            Console.WriteLine("12) Addresses");
            Console.WriteLine("13) Customers");
            Console.WriteLine("14) Payments");
            Console.WriteLine("15) Orders");
            Console.WriteLine("16) Manifest Items");

            Console.Write("Select a table (or 0 to exit): ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
