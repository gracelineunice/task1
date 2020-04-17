using Microsoft.EntityFrameworkCore;
using Task.models;

namespace Task.models
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}