using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{

    public class DataContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
       // public DbSet<PostTag> PostTags { get; set; }
        public DbSet<User> Users { get; set; }

      //  public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=SA;Password=1q2w3e4r@#$");
        }
    }
}