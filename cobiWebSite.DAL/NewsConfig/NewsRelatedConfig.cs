using CobiWebSite.Model.News.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobiWebSite.DAL.NewsConfig
{
    public class NewsRelatedConfig : IEntityTypeConfiguration<NewseRelated>
    {
        public void Configure(EntityTypeBuilder<NewseRelated> builder)
        {
            
        }
    }
}
