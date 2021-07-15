using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Blog.Repositories
{
    public class UserRepository
    {
        private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";
        private SqlConnection _connection = new SqlConnection(CONNECTION_STRING);

        public IEnumerable<User> GetAll() => _connection.GetAll<User>();

        public User ReadOne(int userId) => _connection.Get<User>(userId);

        public void Create(User user) => _connection.Insert<User>(user);

        public void Update(User user) => _connection.Update(user);

        public void Delete(int userId)
        {
            var user = _connection.Get<User>(userId);
            _connection.Delete(user);
        }
    }
}

