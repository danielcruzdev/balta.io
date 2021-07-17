﻿using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Repositories
{
    public class Repository<TModel> where TModel : class
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection) => _connection = connection;

        public long Create(TModel model) => _connection.Insert(model);

        public List<TModel> Read() => _connection.GetAll<TModel>().ToList();

        public TModel Read(int id) => _connection.Get<TModel>(id);

        public void Update(TModel model) => _connection.Update(model);

        public void Delete(TModel model) => _connection.Delete(model);
    }
}
