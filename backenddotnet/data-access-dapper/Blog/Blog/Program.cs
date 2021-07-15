using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;
using System;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();

            //CreateUser();
            //UpdateUser();
            //DeleteUser(2);
            //ReadUsers();
            //ReadUser(1);

            connection.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var users = repository.GetAll();

            foreach (var user in users)
                Console.WriteLine($"Usuário: {user.Name}");
        }

        public static void ReadUser(int userId, SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var user = repository.GetOneById(userId);

            Console.WriteLine($"Usuário: {user.Name}");
        }

        public static void CreateUser(SqlConnection connection)
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

            var repository = new UserRepository(connection);
            repository.Create(user);

            Console.WriteLine("Cadastro realizado com sucesso!");
        }

        public static void UpdateUser(SqlConnection connection)
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

            var repository = new UserRepository(connection);
            repository.Update(user);

            Console.WriteLine("Atualização realizada com sucesso!");
        }

        public static void DeleteUser(int userId, SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            repository.Delete(userId);

            Console.WriteLine("Exclusão realizada com sucesso!");
        }
    }
}
