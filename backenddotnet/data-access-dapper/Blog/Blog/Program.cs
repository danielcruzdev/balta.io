using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog
{
    public class Program
    {
        private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

        static void Main(string[] args)
        {
            using var connection = new SqlConnection(CONNECTION_STRING);
            var userRepository = new Repository<User>(connection);
            var repository = new Repository<Role>(connection);

            var user = new User()
            {
                Name = "Usuário Desafio",
                Bio = "Bio - Usuário Desafio",
                Email = "desafio@usuario.com.br",
                Image = "https://...",
                PasswordHash = "HASH",
                Slug = "usuario-desafio"
            };

            var role = new Role()
            {
                Name = "Teste",
                Slug = "teste"
            };

            var userId = CreateUser(userRepository, user);
            //CreateRole(repository, role);
        }

        private static long CreateUser(Repository<User> repository, User user)
        {
            return repository.Create(user);
        }

        private static long CreateRole(Repository<Role> repository, Role role)
        {
            return repository.Create(role);
        }

        private static long LinkUserToRole(Repository<UserRole> repository, UserRole userRole)
        {
            return repository.Create(userRole);
        }
    }
}
