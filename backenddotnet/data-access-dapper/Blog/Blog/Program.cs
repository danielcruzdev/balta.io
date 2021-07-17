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
            var roleRepository = new Repository<Role>(connection);
            var userRoleRepository = new Repository<UserRole>(connection);

            var user = new User()
            {
                Name = "Usuário Desafio2",
                Bio = "Bio - Usuário Desafio2",
                Email = "desafio2@usuario.com.br",
                Image = "https://...",
                PasswordHash = "HASH",
                Slug = "usuario-desafio2"
            };

            var role = new Role()
            {
                Name = "Teste",
                Slug = "teste"
            };

            var userId = CreateUser(userRepository, user);

            var userRole = new UserRole { RoleId = 1, UserId = (int)userId };

            LinkUserToRole(userRoleRepository, userRole);
            //CreateRole(roleRepository, role);
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
