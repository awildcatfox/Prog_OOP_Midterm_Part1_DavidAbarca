using Prog_OOP_Midterm_Part1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_oop_midterm_part1
{
    internal class Database
    {
        List<Product> tempdata = new List<Product>();

        static Database _instance = null;

        private Database(ConnectionStringParser csp)
        {
            PopulateData(csp.database);
        }

        public static Database ConnectToDatabase(string connectionstring)
        {
            ConnectionStringParser csp = new ConnectionStringParser(connectionstring);

            if (!csp.isvalid())
            {
                Console.WriteLine("the connection string you entered was invalid. check all of your arguments");
                return null;
            }

            if (!ValidateInfo(csp)) return null;

            if (_instance == null)
            {
                _instance = new Database(csp);
            }

            return _instance;
        }

        private void PopulateData(string database)
        {
            if (database == "training")
            {
                tempdata = new List<Product>
                {
                    new Clothing("t-shirt", 19.99, "medium", "red"),
                    new Electronics("smartphone", 799.99, "apple"),
                    new Groceries("banana", 0.99, "2024-02-10"),
                    new Clothing("jeans", 39.99, "large", "blue"),
                    new Electronics("laptop", 1499.99, "dell"),
                    new Groceries("apple", 1.99, "2024-02-15"),
                    new Clothing("dress", 49.99, "small", "black"),
                    new Electronics("tablet", 499.99, "samsung"),
                    new Groceries("orange", 0.79, "2024-02-12"),
                    new Clothing("jacket", 59.99, "medium", "green"),
                };
            }
            else
            {
                tempdata = new List<Product> {
            new Clothing("t-shirt", 19.99, "medium", "red"),
            new Electronics("smartphone", 799.99, "apple"),
            new Groceries("banana", 0.99, "2024-02-10"),
            new Clothing("jeans", 39.99, "large", "blue"),
            new Electronics("laptop", 1499.99, "dell"),
            new Groceries("apple", 1.99, "2024-02-15"),
            new Clothing("dress", 49.99, "small", "black"),
            new Electronics("tablet", 499.99, "samsung"),
            new Groceries("orange", 0.79, "2024-02-12"),
            new Clothing("jacket", 59.99, "medium", "green"),
            new Electronics("smartwatch", 199.99, "fitbit"),
            new Groceries("grapes", 1.49, "2024-02-14"),
            new Clothing("sweater", 29.99, "large", "gray"),
            new Electronics("desktop computer", 899.99, "hp"),
            new Groceries("pineapple", 2.99, "2024-02-20"),
            new Clothing("hat", 9.99, "one size", "white"),
            new Electronics("bluetooth speaker", 79.99, "jbl"),
            new Groceries("mango", 1.29, "2024-02-17"),
            new Clothing("shorts", 29.99, "medium", "blue"),
            new Electronics("digital camera", 299.99, "canon"),
            new Groceries("cherry", 1.59, "2024-02-25"),
            new Clothing("socks", 4.99, "one size", "black"),
            new Electronics("headphones", 149.99, "sony"),
            new Groceries("watermelon", 3.49, "2024-02-28"),
            new Clothing("gloves", 7.99, "medium", "brown"),
            new Electronics("gaming console", 399.99, "microsoft"),
            new Groceries("blueberry", 1.69, "2024-03-05"),
            new Clothing("scarf", 12.99, "one size", "blue"),
            new Electronics("smartphone 1", 799.99, "apple"),
            new Groceries("milk", 2.49, "2024-02-10"),
            new Clothing("shorts 1", 24.99, "large", "gray"),
            new Electronics("laptop 1", 1499.99, "dell"),
            new Groceries("eggs", 1.99, "2024-02-15"),
            new Clothing("sweatshirt 1", 34.99, "large", "gray"),
            new Electronics("tablet 1", 499.99, "samsung"),
            new Groceries("bread", 2.99, "2024-02-12"),
            new Clothing("dress 1", 39.99, "small", "red"),
            new Electronics("smartwatch 1", 199.99, "fitbit"),
            new Groceries("apples", 1.29, "2024-02-14"),
            new Clothing("jeans 1", 49.99, "large", "black"),
            new Electronics("desktop computer 1", 899.99, "hp"),
            new Groceries("pasta", 1.49, "2024-02-17"),
            new Clothing("shoes 1", 59.99, "8", "white"),
            new Electronics("digital camera 1", 299.99, "canon"),
            new Groceries("oranges", 0.99, "2024-02-20"),
            new Clothing("hat 1", 12.99, "one size", "green"),
            new Electronics("bluetooth speaker 1", 79.99, "jbl"),
            new Groceries("cereal", 3.49, "2024-02-22"),
            new Clothing("socks 1", 4.99, "one size", "black"),
            new Electronics("headphones 1", 149.99, "sony"),
            new Groceries("tomatoes", 1.79, "2024-02-25"),
            new Clothing("gloves 1", 7.99, "medium", "brown"),
            new Electronics("gaming console 1", 399.99, "microsoft"),
            new Groceries("potatoes", 1.49, "2024-02-28"),
            new Clothing("scarf 1", 12.99, "one size", "blue"),
            new Electronics("smartphone 2", 899.99, "samsung"),
            new Groceries("carrots", 1.29, "2024-03-02"),
            new Clothing("t-shirt 2", 17.99, "large", "white"),
            new Electronics("smart tv 1", 899.99, "lg"),
            new Groceries("onions", 0.79, "2024-03-05"),
            new Clothing("dress 2", 44.99, "medium", "purple"),
            new Electronics("wireless mouse 1", 24.99, "logitech"),
            new Groceries("bell peppers", 1.99, "2024-03-08"),
            new Clothing("jeans 2", 45.99, "medium", "black"),
            new Electronics("e-book reader 1", 119.99, "amazon"),
            new Groceries("cucumbers", 0.99, "2024-03-10"),
            new Clothing("shoes 2", 69.99, "9", "brown"),
                };
            }
        }

        private static bool ValidateInfo(ConnectionStringParser csp)
        {
            if (csp.server != "cramberryfarms")
            {
                Console.WriteLine("unrecognized database name");
                return false;
            }

            if (csp.database != "training" && csp.database != "main")
            {
                Console.WriteLine("unrecognized server name");
                return false;
            }

            if (csp.uid != "admin")
            {
                Console.WriteLine("unrecognized admin name");
                return false;
            }

            if (csp.password != "1234")
            {
                Console.WriteLine("unrecognized password");
                return false;
            }

            return true;
        }

        public static bool IsConnected()
        {
            return !(_instance == null);
        }

        public List<Product> Data()
        {
            return tempdata;
        }

        private class ConnectionStringParser
        {
            public string driver { get; set; }
            public string server { get; set; }
            public string database { get; set; }
            public string uid { get; set; }
            public string password { get; set; }

            public ConnectionStringParser(string connectionstring)
            {
                string[] parts = connectionstring.Split(';');
                foreach (var part in parts)
                {
                    var keyvalue = part.Split('=');
                    if (keyvalue.Length == 2)
                    {
                        var key = keyvalue[0].Trim();
                        var value = keyvalue[1].Trim();
                        switch (key.ToLower())
                        {
                            case "driver":
                                driver = value;
                                break;
                            case "server":
                                server = value;
                                break;
                            case "database":
                                database = value;
                                break;
                            case "uid":
                                uid = value;
                                break;
                            case "pwd":
                                password = value;
                                break;
                        }
                    }
                }
            }

            public bool isvalid()
            {
                return !string.IsNullOrWhiteSpace(driver)
                    && !string.IsNullOrWhiteSpace(server)
                    && !string.IsNullOrWhiteSpace(database)
                    && !string.IsNullOrWhiteSpace(uid)
                    && !string.IsNullOrWhiteSpace(password);
            }
        }
    }
}
