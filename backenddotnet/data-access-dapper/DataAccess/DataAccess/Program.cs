using System;
using System.Collections.Generic;
using Dapper;
using DataAccess.Models;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$";

            using(var connection = new SqlConnection(connectionString))
            {
                var categories = connection.Query<Category>($@"SELECT * 
                                                                 FROM Category");

                foreach (var category in categories)
                {
                    Console.WriteLine(category.Id);
                    Console.WriteLine(category.Title);
                    Console.WriteLine(category.Url);
                    Console.WriteLine(category.Summary);
                    Console.WriteLine(category.Order);
                    Console.WriteLine(category.Description);
                    Console.WriteLine(category.Featured);
                    Console.WriteLine("------------------------");
                }
            }
        }
    }
}