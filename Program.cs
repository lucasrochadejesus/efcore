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
           using(var context = new DataContext())
           {

                // #### Create
                // var tag = new Tag{ Name="ASP.NET", Slug="aspnet"};
                //   context.Tags.Add(tag);
                //   context.SaveChanges();

                // #### Update
                // read item from database
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 5);
                // tag.Name = ".NET Core";
                // tag.Slug = ".Net Entity Framework Core.";
                // context.Update(tag);
                // context.SaveChanges();

                // ### Delete
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 5);
                // context.Remove(tag);
                // context.SaveChanges();

                // Search
                // var tags = context.Tags
                // .Where(x=> x.Name.Contains("Core"))
                // .ToList();

                // foreach (var tag in tags)
                // {
                //     Console.WriteLine(tag.Name);
                // }

                var tag = context.Tags
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == 5);
                Console.WriteLine(tag?.Name);

           }

        }
    }
}
