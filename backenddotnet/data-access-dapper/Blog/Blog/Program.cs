using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog
{
    public class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

        static void Main(string[] args)
        {
            using var connection = new SqlConnection(CONNECTION_STRING);
            var repository = new Repository<User>(connection);

            var user = new User()
            {
                Name = "Usuário Desafio",
                Bio = "Bio - Usuário Desafio",
                Email = "desafio@usuario.com.br",
                Image = "https://...",
                PasswordHash = "HASH",
                Slug = "usuario-desafio"
            };

            CreateUser(repository, user);
        }

        private static void CreateUser(Repository<User> repository, User user)
        {
            repository.Create(user);
        }
    }
}
