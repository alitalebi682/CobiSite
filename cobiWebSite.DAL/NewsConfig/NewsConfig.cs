using CobiWebSite.Model.News.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cobiWebSite.DAL.NewsConfig;

public class NewsConfig : IEntityTypeConfiguration<NewsBase>
{
    public void Configure(EntityTypeBuilder<NewsBase> builder)
    {
        //modelBuilder.Entity<Student>()
        //       .HasOptional(s => s.Address) // Mark Address property optional in Student entity
        //       .WithRequired(ad => ad.Student);
        //builder.Property(c => c.ImageUrl).IsRequired().HasMaxLength(1000);
        //builder.Property(c => c.Title).IsRequired().HasMaxLength(100);
        //builder.Property(c => c.Description).IsRequired();
        //builder.Property(c => c.ShortDescription).IsRequired().HasMaxLength(500);

      builder.Property(c =>c.Mainnews).IsRequired( );
       
    }
}