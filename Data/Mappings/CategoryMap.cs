using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{

    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            // Table
           builder.ToTable("Category");
           
           // Primary Key
           builder.HasKey(x=>x.Id);

            // Identity 
           builder.Property(x=>x.Id)
           .ValueGeneratedOnAdd()
           .UseIdentityColumn();
           

        }
    }
}