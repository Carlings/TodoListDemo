using Microsoft.EntityFrameworkCore;
using TodoListDemo.Data.Models;

namespace TodoListDemo.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {            
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
