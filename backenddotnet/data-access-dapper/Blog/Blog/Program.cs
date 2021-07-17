using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog
{
    public class Program
    {
        private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

        static void Main(string[] args)
        {
            using var connection = new SqlConnection(CONNECTION_STRING);
            var userRepository = new UserRepository(connection);

            var users = ListUsersWithRoles(userRepository);

            foreach (var user in users)
            {
                Console.WriteLine($"Nome: {user.Name}");
                Console.WriteLine($"Email: {user.Email}");

                if (user.Roles.Count() > 0 && user.Roles[0] != null)
                {
                    Console.Write($"Roles: ");
                    for (int i = 0; i < user.Roles.Count; i++)
                    {
                        if (i < (user.Roles.Count - 1))
                            Console.Write($"{user.Roles[i]?.Name}, ");
                        else
                            Console.Write($"{user.Roles[i]?.Name}");
                    }
                    Console.WriteLine("\n---------------------");
                }
                else
                {
                    Console.WriteLine($"Usuário sem role!");
                    Console.WriteLine("---------------------");
                }
            }
        }

        private static IEnumerable<User> ListUsersWithRoles(UserRepository userRepository)
        {
            return userRepository.ReadWithRole();
        }
    }
}