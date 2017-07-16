using System;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        //creates a table with the following names: (should be pluralized)
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
