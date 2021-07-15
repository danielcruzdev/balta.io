using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Blog.Repositories
{
    public class UserRepository
    {
        public UserRepository(SqlConnection connection) => _connection = connection;

        private readonly SqlConnection _connection;

        public IEnumerable<User> GetAll() => _connection.GetAll<User>();

        public User GetOneById(int userId) => _connection.Get<User>(userId);

        public void Create(User user) => _connection.Insert(user);

        public void Update(User user) => _connection.Update(user);

        public void Delete(int userId)
        {
            var user = _connection.Get<User>(userId);
            _connection.Delete(user);
        }
    }
}

