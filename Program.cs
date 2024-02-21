using prog_oop_midterm_part1;

namespace Prog_OOP_Midterm_Part1
{// David Abarca
    // 2/18/24
    internal class Program
    {
        static void Main()
        {
            // Using our UpdateConfig method to change our connection string. Make sure to pass in the correct information
            Config.UpdateConnectionString("CramberryFarms", "training", "Admin", "1234");

            // Saving the connectionString to a local variable
            string ConnectionString = Config.ConnectionString;

            // Using the Database.ConnectToDatabase() method that takes a formatted connection string to connect
            Database db = Database.ConnectToDatabase(ConnectionString);

            // If it connects, grab the data as a list of product
            // In the real world theres a lot of framework and code to make this happen
            List<Product> data = db.Data();

            // Display our list of product from the training table.
            foreach (Product d in data)
            {
                d.DisplayProductInfo();
            }
        }

        //public static void datalist() 
        //{

        //    // Access the static property to get the data
        //    List<string> dataList = MyDatabase.data;

        //    // Display the data from the static class
        //    foreach (string item in dataList)
        //    {
        //        Console.WriteLine(item);
        //    }


        //}








    }
}
