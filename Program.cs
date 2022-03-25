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
               PasswordHash = "1234"
               
           };
        }
    }
}
