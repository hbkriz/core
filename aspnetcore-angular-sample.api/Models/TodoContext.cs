using Microsoft.EntityFrameworkCore;

namespace aspnetcore_angular_sample.api.Models
{
     public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

    }
}