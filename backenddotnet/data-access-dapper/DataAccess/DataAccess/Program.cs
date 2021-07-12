using Dapper;
using DataAccess.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$";

            var category = new Category()
            {
                Id = new Guid("8618e919-60e4-429e-b468-79c7fc0f4151"),
                Title = "Google Cloud",
                Url = "cloud",
                Description = "Categoria destinada a serviços Google Cloud",
                Order = 10,
                Summary = "Google Cloud",
                Featured = true
            };


            using (var connection = new SqlConnection(connectionString))
            {
                ListCategories(connection);
                //CreateCategory(connection, category);
                UpdateCategory(connection, category);
            }
        }

        static void DeleteCategory(SqlConnection connection, Category category)
        {
            var parameters = GetParameters(category);

            var deleteSql = @"
                    DELETE a 
                      FROM Category
                     WHERE a.Id = @Id";

            var rows = connection.Execute(deleteSql, parameters);

            Console.WriteLine($"Linhas deletadas - {rows}");
        }

        static void UpdateCategory(SqlConnection connection, Category category)
        {
            var parameters = GetParameters(category);

            var updateSql = @"
                    UPDATE a 
                       SET a.Title = @Title,
                           a.Url = @Url,
                           a.Description = @Description,
                           a.Order = @Order,
                           a.Summary = @Summary,
                           a.Featured = @Featured
                      FROM Category a
                     WHERE a.Id = @Id";

            var rows = connection.Execute(updateSql, parameters);

            Console.WriteLine($"Linhas atualizadas - {rows}");
        }

        static void CreateCategory(SqlConnection connection, Category category)
        {
            var parameters = GetParameters(category);

            var insertSql = @"
                    INSERT INTO Category 
                         VALUES (@Id, @Title, @Url, @Description, @Order, @Summary, @Featured)";

            var rows = connection.Execute(insertSql, parameters);

            Console.WriteLine($"Linhas inseridas - {rows}");
        }

        static void ListCategories(SqlConnection connection)
        {
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

        static DynamicParameters GetParameters(Category category)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", category.Id, DbType.Guid);
            parameters.Add("@Title", category.Title, DbType.String);
            parameters.Add("@Url", category.Url, DbType.String);
            parameters.Add("@Description", category.Description, DbType.String);
            parameters.Add("@Order", category.Order, DbType.Int32);
            parameters.Add("@Summary", category.Summary, DbType.String);
            parameters.Add("@Featured", category.Featured, DbType.Boolean);

            return parameters;
        }
    }
}