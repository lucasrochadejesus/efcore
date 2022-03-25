using System;
using System.Linq;
using Blog.Data;
using Blog.Models;


namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
           using(var context = new DataContext())
           {

            // Create
              // var tag = new Tag{ Name="ASP.NET", Slug="aspnet"};
              //   context.Tags.Add(tag);
              //   context.SaveChanges();

             // Update
             var tag = context.Tags.FirstOrDefault(x => x.Id == 5);
             tag.Name = ".NET Core";
             tag.Slug = ".Net Entity Framework Core.";
             context.Update(tag);
             context.SaveChanges();



           }

        }
    }
}
