﻿namespace Prog_OOP_Midterm_Part1
{// David Abarca
    // 2/18/24
    internal class Program
    {
        static void Main()
        {
            // Access the static property to get the data
            List<Product> dataList = MyDatabase.Data;

            // Display the data from the static class
            foreach (Product product in dataList)
            {

                product.DisplayProductInfo();
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
