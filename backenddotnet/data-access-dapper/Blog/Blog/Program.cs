using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

        static void Main(string[] args)
        {
            CreateUser();
            //UpdateUser();
            //DeleteUser(2);
            ReadUsers();
            //ReadUser(1);
        }

        public static void ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.GetAll<User>();

                foreach (var user in users)
                {
                    Console.WriteLine($"Usuário: {user.Name}");
                }
            }
        }

        public static void ReadUser(int userId)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(userId);

                Console.WriteLine($"Usuário: {user.Name}");
            }
        }

        public static void CreateUser()
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
                var row = connection.Insert<User>(user);

                Console.WriteLine($"Cadastro realizado com sucesso!");
            }
        }

        public static void UpdateUser()
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
                var row = connection.Update(user);

                Console.WriteLine($"Atualização realizada com sucesso!");
            }
        }

        public static void DeleteUser(int userId)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(userId);
                var row = connection.Delete(user);

                Console.WriteLine($"Exclusão realizada com sucesso!");
            }
        }
    }
}
