using Dapper;
using DataAccess.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
                Title = "Google Cloud333333",
                Url = "cloud333333",
                Description = "Categoria destinada a serviços Google Cloud3333333",
                Order = 12,
                Summary = "Google Clou333333333333",
                Featured = true
            };

            var category2 = new Category()
            {
                Id = Guid.NewGuid(),
                Title = "Google Cloud2",
                Url = "cloud2",
                Description = "Categoria destinada a serviços Google Cloud2",
                Order = 10,
                Summary = "Google Cloud2",
                Featured = true
            };

            var categories = new List<Category>();
            categories.Add(category);
            categories.Add(category2);

            using (var connection = new SqlConnection(connectionString))
            {
                //ListCategories(connection);
                //ExecuteReadProcedure(connection);
                //CreateManyCategory(connection, categories);
                //CreateCategory(connection, category);
                //UpdateCategory(connection, category);
                //DeleteCategory(connection, category.Id);
                //ExecuteScalar(connection, category);
                //ExecuteReadView(connection);
                //OneToOne(connection);
                //OneToMany(connection);
                //QueryMultiple(connection);
                //SelectIn(connection);
                //Like(connection);
            }
        }

        static void DeleteCategory(SqlConnection connection, Guid categoryId)
        {

            var deleteSql = @"
                    DELETE FROM [Category]
                     WHERE [Id] = @Id";

            var rows = connection.Execute(deleteSql, new
            {
                Id = categoryId
            });

            Console.WriteLine($"Linhas deletadas - {rows}");
        }

        static void UpdateCategory(SqlConnection connection, Category category)
        {
            var parameters = GetParameters(category);

            var updateSql = @"
                    UPDATE [Category]
                       SET [Title] = @Title,
                           [Url] = @Url,
                           [Description] = @Description,
                           [Order] = @Order,
                           [Summary] = @Summary,
                           [Featured] = @Featured
                     WHERE [Id] = @Id";

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

        static void ExecuteScalar(SqlConnection connection, Category category)
        {
            var parameters = GetParameters(category);

            var insertSql = @"
                    INSERT INTO Category 
                         OUTPUT inserted.Id
                         VALUES (NEWID(), @Title, @Url, @Description, @Order, @Summary, @Featured)";

            var id = connection.ExecuteScalar<Guid>(insertSql, parameters);

            Console.WriteLine($"ID da categoria inserida - {id}");
        }

        static void CreateManyCategory(SqlConnection connection, List<Category> categories)
        {
            var parameters = new List<DynamicParameters>();
            var parameter = GetParameters(categories[0]);
            var parameter2 = GetParameters(categories[1]);

            parameters.Add(parameter);
            parameters.Add(parameter2);

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

        static void ExecuteProcedure(SqlConnection connection)
        {
            var parametros = new { StudentId = "79b82071-80a8-4e78-a79c-92c8cd1fd052" };

            connection.Execute("spDeleteStudent", parametros, commandType: CommandType.StoredProcedure);
        }

        static void ExecuteReadProcedure(SqlConnection connection)
        {
            var parametros = new { CategoryId = "09ce0b7b-cfca-497b-92c0-3290ad9d5142" };

            var courses = connection.Query("spGetCoursesByCategory", parametros, commandType: CommandType.StoredProcedure);

            foreach (var item in courses)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Title);
                Console.WriteLine("------------------");
            }
        }

        static void ExecuteReadView(SqlConnection connection)
        {
            var sqlView = "SELECT * FROM [vwCourses]";

            var courses = connection.Query(sqlView, commandType: CommandType.Text);

            foreach (var item in courses)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Title);
                Console.WriteLine("------------------");
            }
        }

        static void OneToOne(SqlConnection connection)
        {
            var sql = @"SELECT * 
                          FROM [CareerItem] 
                      INNER JOIN [Course] ON [CareerItem].[CourseId] = [Course].[Id]";

            var itens = connection.Query<CareerItem, Course, CareerItem>(sql, (carrerItem, course) =>
            {
                carrerItem.Course = course;
                return carrerItem;
            }, splitOn: "Id");

            foreach (var item in itens)
            {
                Console.WriteLine(item.Course.Title);
            }
        }

        static void OneToMany(SqlConnection connection)
        {
            var sql = @"SELECT [Career].[Id],
                               [Career].[Title],
                               [CareerItem].[CareerId],
                               [CareerItem].[Title]
                          FROM [Career] 
                      INNER JOIN [CareerItem] ON [CareerItem].[CareerId] = [Career].[Id]
                       ORDER BY [Career].[Title]";

            var careers = new List<Career>();

            var items = connection.Query<Career, CareerItem, Career>(sql, (career, careerItem) =>
            {

                var car = careers.Where(x => x.Id == career.Id).FirstOrDefault();

                if (car == null)
                {
                    car = career;
                    car.Items.Add(careerItem);
                    careers.Add(car);
                }
                else
                {
                    car.Items.Add(careerItem);
                }

                return career;
            }, splitOn: "CareerId");

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var careerItem in career.Items)
                {
                    Console.WriteLine(careerItem.Title);
                }

                Console.WriteLine("-------------------------");
            }
        }

        static void QueryMultiple(SqlConnection connection)
        {
            var query = @"SELECT * FROM Category;
                          SELECT * FROM Course";

            using (var multi = connection.QueryMultiple(query))
            {
                var categories = multi.Read<Category>();
                var courses = multi.Read<Course>();

                Console.WriteLine("Categorias");
                foreach (var item in categories)
                {
                    Console.WriteLine(item.Title);
                }
                Console.WriteLine("---------------------");

                Console.WriteLine();

                Console.WriteLine("Cursos");
                foreach (var item in courses)
                {
                    Console.WriteLine(item.Title);
                }
                Console.WriteLine("---------------------");
            }
        }

        static void SelectIn(SqlConnection connection)
        {
            var query = @"SELECT * FROM Career WHERE [Id] IN @Id";

            var items = connection.Query<Career>(query, new
            {
                Id = new[]
                {
                    "01ae8a85-b4e8-4194-a0f1-1c6190af54cb",
                    "92d7e864-bea5-4812-80cc-c2f4e94db1af"
                }
            });


            foreach (var item in items)
            {
                Console.WriteLine(item.Title);
            }
        }

        static void Like(SqlConnection connection)
        {
            var query = @"SELECT * FROM Course WHERE [Title] LIKE @Exp";

            var items = connection.Query<Career>(query, new
            {
                Exp = "%C#%"
            });


            foreach (var item in items)
            {
                Console.WriteLine(item.Title);
            }
        }

        static void Transaction(SqlConnection connection, Category category)
        {
            var parameters = GetParameters(category);

            var insertSql = @"
                    INSERT INTO Category 
                         VALUES (@Id, @Title, @Url, @Description, @Order, @Summary, @Featured)";

            int rows;
            using (var transaction = connection.BeginTransaction())
            {
                rows = connection.Execute(insertSql, parameters, transaction);

                transaction.Commit();
            }

            Console.WriteLine($"Linhas inseridas - {rows}");
        }

        static DynamicParameters GetParameters(Category category)
        {
            var parameters = new DynamicParameters();
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