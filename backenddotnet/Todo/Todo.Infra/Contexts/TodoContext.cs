using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entities;

namespace Todo.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<TodoItem> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().ToTable("Todo");
            modelBuilder.Entity<TodoItem>().Property(x => x.Id);
            modelBuilder.Entity<TodoItem>().Property(x => x.User).HasMaxLength(120).HasColumnType("VARCHAR(120)");
            modelBuilder.Entity<TodoItem>().Property(x => x.Title).HasMaxLength(160).HasColumnType("VARCHAR(160)");
            modelBuilder.Entity<TodoItem>().Property(x => x.Done).HasColumnType("BIT");
            modelBuilder.Entity<TodoItem>().Property(x => x.Date);
            modelBuilder.Entity<TodoItem>().HasIndex(x => x.User);
        }
    }
}
