using CobiWebSite.Model.News.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cobiWebSite.DAL.NewsConfig;

public class NewsConfig : IEntityTypeConfiguration<NewsBase>
{
    public void Configure(EntityTypeBuilder<NewsBase> builder)
    {

    }
}