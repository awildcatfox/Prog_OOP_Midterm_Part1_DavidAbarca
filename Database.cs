using System.collections.generic;
using System.componentmodel.dataannotations;
using System.linq;
using System.text;
using System.threading.tasks;

namespace prog_oop_midterm_part1
{
    internal class database
    {
        list<product> tempdata = new list<product>();

        static database _instance = null;

        private database(connectionstringparser csp)
        {
            populatedata(csp.database);
        }

        public static database connecttodatabase(string connectionstring)
        {
            connectionstringparser csp = new connectionstringparser(connectionstring);

            if (!csp.isvalid())
            {
                console.writeline("the connection string you entered was invalid. check all of your arguments");
                return null;
            }

            if (!validateinfo(csp)) return null;

            if (_instance == null)
            {
                _instance = new database(csp);
            }

            return _instance;
        }

        private void populatedata(string database)
        {
            if (database == "training")
            {
                tempdata = new list<product>
                {
                    new clothing("t-shirt", 19.99, "medium", "red"),
                    new electronics("smartphone", 799.99, "apple"),
                    new groceries("banana", 0.99, "2024-02-10"),
                    new clothing("jeans", 39.99, "large", "blue"),
                    new electronics("laptop", 1499.99, "dell"),
                    new groceries("apple", 1.99, "2024-02-15"),
                    new clothing("dress", 49.99, "small", "black"),
                    new electronics("tablet", 499.99, "samsung"),
                    new groceries("orange", 0.79, "2024-02-12"),
                    new clothing("jacket", 59.99, "medium", "green"),
                };
            }
            else
            {
                tempdata = new list<product> {
            new clothing("t-shirt", 19.99, "medium", "red"),
            new electronics("smartphone", 799.99, "apple"),
            new groceries("banana", 0.99, "2024-02-10"),
            new clothing("jeans", 39.99, "large", "blue"),
            new electronics("laptop", 1499.99, "dell"),
            new groceries("apple", 1.99, "2024-02-15"),
            new clothing("dress", 49.99, "small", "black"),
            new electronics("tablet", 499.99, "samsung"),
            new groceries("orange", 0.79, "2024-02-12"),
            new clothing("jacket", 59.99, "medium", "green"),
            new electronics("smartwatch", 199.99, "fitbit"),
            new groceries("grapes", 1.49, "2024-02-14"),
            new clothing("sweater", 29.99, "large", "gray"),
            new electronics("desktop computer", 899.99, "hp"),
            new groceries("pineapple", 2.99, "2024-02-20"),
            new clothing("hat", 9.99, "one size", "white"),
            new electronics("bluetooth speaker", 79.99, "jbl"),
            new groceries("mango", 1.29, "2024-02-17"),
            new clothing("shorts", 29.99, "medium", "blue"),
            new electronics("digital camera", 299.99, "canon"),
            new groceries("cherry", 1.59, "2024-02-25"),
            new clothing("socks", 4.99, "one size", "black"),
            new electronics("headphones", 149.99, "sony"),
            new groceries("watermelon", 3.49, "2024-02-28"),
            new clothing("gloves", 7.99, "medium", "brown"),
            new electronics("gaming console", 399.99, "microsoft"),
            new groceries("blueberry", 1.69, "2024-03-05"),
            new clothing("scarf", 12.99, "one size", "blue"),
            new electronics("smartphone 1", 799.99, "apple"),
            new groceries("milk", 2.49, "2024-02-10"),
            new clothing("shorts 1", 24.99, "large", "gray"),
            new electronics("laptop 1", 1499.99, "dell"),
            new groceries("eggs", 1.99, "2024-02-15"),
            new clothing("sweatshirt 1", 34.99, "large", "gray"),
            new electronics("tablet 1", 499.99, "samsung"),
            new groceries("bread", 2.99, "2024-02-12"),
            new clothing("dress 1", 39.99, "small", "red"),
            new electronics("smartwatch 1", 199.99, "fitbit"),
            new groceries("apples", 1.29, "2024-02-14"),
            new clothing("jeans 1", 49.99, "large", "black"),
            new electronics("desktop computer 1", 899.99, "hp"),
            new groceries("pasta", 1.49, "2024-02-17"),
            new clothing("shoes 1", 59.99, "8", "white"),
            new electronics("digital camera 1", 299.99, "canon"),
            new groceries("oranges", 0.99, "2024-02-20"),
            new clothing("hat 1", 12.99, "one size", "green"),
            new electronics("bluetooth speaker 1", 79.99, "jbl"),
            new groceries("cereal", 3.49, "2024-02-22"),
            new clothing("socks 1", 4.99, "one size", "black"),
            new electronics("headphones 1", 149.99, "sony"),
            new groceries("tomatoes", 1.79, "2024-02-25"),
            new clothing("gloves 1", 7.99, "medium", "brown"),
            new electronics("gaming console 1", 399.99, "microsoft"),
            new groceries("potatoes", 1.49, "2024-02-28"),
            new clothing("scarf 1", 12.99, "one size", "blue"),
            new electronics("smartphone 2", 899.99, "samsung"),
            new groceries("carrots", 1.29, "2024-03-02"),
            new clothing("t-shirt 2", 17.99, "large", "white"),
            new electronics("smart tv 1", 899.99, "lg"),
            new groceries("onions", 0.79, "2024-03-05"),
            new clothing("dress 2", 44.99, "medium", "purple"),
            new electronics("wireless mouse 1", 24.99, "logitech"),
            new groceries("bell peppers", 1.99, "2024-03-08"),
            new clothing("jeans 2", 45.99, "medium", "black"),
            new electronics("e-book reader 1", 119.99, "amazon"),
            new groceries("cucumbers", 0.99, "2024-03-10"),
            new clothing("shoes 2", 69.99, "9", "brown"),
        };
            }
        }

        private static bool validateinfo(connectionstringparser csp)
        {
            if (csp.server != "cramberryfarms")
            {
                console.writeline("unrecognized database name");
                return false;
            }

            if (csp.database != "training" && csp.database != "main")
            {
                console.writeline("unrecognized server name");
                return false;
            }

            if (csp.uid != "admin")
            {
                console.writeline("unrecognized admin name");
                return false;
            }

            if (csp.password != "1234")
            {
                console.writeline("unrecognized password");
                return false;
            }

            return true;
        }

        public static bool isconnected()
        {
            return !(_instance == null);
        }

        public list<product> data()
        {
            return tempdata;
        }

        private class connectionstringparser
        {
            public string driver { get; set; }
            public string server { get; set; }
            public string database { get; set; }
            public string uid { get; set; }
            public string password { get; set; }

            public connectionstringparser(string connectionstring)
            {
                string[] parts = connectionstring.split(';');
                foreach (var part in parts)
                {
                    var keyvalue = part.split('=');
                    if (keyvalue.length == 2)
                    {
                        var key = keyvalue[0].trim();
                        var value = keyvalue[1].trim();
                        switch (key.tolower())
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
                return !string.isnullorwhitespace(driver)
                    && !string.isnullorwhitespace(server)
                    && !string.isnullorwhitespace(database)
                    && !string.isnullorwhitespace(uid)
                    && !string.isnullorwhitespace(password);
            }
        }
    }
}
