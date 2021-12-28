using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<TodoModel> Todo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}
