using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Blog.Repositories
{
    public class UserRepository
    {
        private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

        public IEnumerable<User> GetAll()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                return connection.GetAll<User>();
            }
        }

        public static User ReadOne(int userId)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                return connection.Get<User>(userId);
            }
        }

        public static long Create()
        {
            var user = new User()
            {
                Bio = "Equipe Balta.io",
                Email = "hello@balta.io",
                Image = "https://...",
                Name = "Equipe balta",
                PasswordHash = "HASH",
                Slug = "equipe-balta"
            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                return connection.Insert<User>(user);
            }
        }

        public static bool Update()
        {
            var user = new User()
            {
                Id = 2,
                Bio = "Equipe | Balta.io",
                Email = "hello@balta.io",
                Image = "https://...",
                Name = "Equipe de suporte balta",
                PasswordHash = "HASH",
                Slug = "equipe-balta"
            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                return connection.Update(user);
            }
        }

        public static bool Delete(int userId)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(userId);
                return connection.Delete(user);
            }
        }
    }
}
