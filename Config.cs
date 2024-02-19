﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{
    public static class Config
    {
        // Fields for configuration settings
        public static string ConnectionString { get; private set; }

        // Fields for configuration settings
        private static string connectionString;

        // Update Config Information

        public static void UpdateConnectionString(string server, string database, string userName, string password)
        {
            string driver = "Driver={SQL Server Native Client 11.0};";
            string serv = $"Server={server};";
            string db = $"Database={database};";
            string userId = $"Uid={userName};";
            string pass = $"Pwd={password}";

            ConnectionString = $"{driver}{serv}{db}{userId}{pass}";
        }
    }
}