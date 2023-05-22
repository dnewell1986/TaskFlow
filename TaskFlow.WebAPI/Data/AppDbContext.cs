namespace TaskFlow.WebAPI.Data;

using Microsoft.EntityFrameworkCore;
using TaskFlow.WebAPI.Features.Todos;
using TaskFlow.WebAPI.Features.Users;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {
    }

    public DbSet<Todo> Todos { get; set; }
    public DbSet<User> Users { get; set; }
}
