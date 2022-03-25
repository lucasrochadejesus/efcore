using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
           
           using var context = new DataContext();
           
           var user = new User
           {
               Name = "Lucas",
               Slug = "lucasrocha",
               Email = "lucasfecap@icloud.com",
               PasswordHash = "1234",
               Image = "user.png",
               Bio = "bio"
           };

           var category = new Category
           {
               Name = "Back-end",
               Slug = "backend"
           };

           var post = new Post
           {
               Author = user,
               Category = category,
               Body = "<p>Hello Fundamentals</p>",
               Summary = "Fundamentals EF Core.",
               Slug = "EF Core",
               Title = "EF Core Fundamentals",
               CreateDate = DateTime.Now,
               LastUpdateDate = DateTime.Now
           };

           context.Posts.Add(post);
           context.SaveChanges();

        }
    }
}
