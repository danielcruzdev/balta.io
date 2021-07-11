using System;
using System.Collections.Generic;
using System.Data;
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

            var category = new Category()
            {   
                Id = Guid.NewGuid(),
                Title = "Amazon AWS",
                Url = "amazon",
                Description = "Categoria destinada a servços AWS",
                Order = 8,
                Summary = "AWS Cloud",
                Featured = false
            };

            var parameters = new DynamicParameters();
            parameters.Add("@Id", category.Id, DbType.Guid);
            parameters.Add("@Title", category.Title, DbType.String);
            parameters.Add("@Url", category.Url, DbType.String);
            parameters.Add("@Description", category.Id, DbType.String);
            parameters.Add("@Order", category.Id, DbType.Int32);
            parameters.Add("@Summary", category.Id, DbType.String);
            parameters.Add("@Featured", category.Id, DbType.Boolean);
            
            var insertSql = @"
             INSERT INTO Category 
                    VALUES (@Id, @Title, @Url, @Description, @Order, @Summary, @Featured)";

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Execute(insertSql);

                var categories = connection.Query<Category>($@"SELECT * 
                                                                 FROM Category");

                foreach (var item in categories)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.Title);
                    Console.WriteLine(item.Url);
                    Console.WriteLine(item.Summary);
                    Console.WriteLine(item.Order);
                    Console.WriteLine(item.Description);
                    Console.WriteLine(item.Featured);
                    Console.WriteLine("------------------------");
                }
            }
        }
    }
}