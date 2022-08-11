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
    public class GroupNewsConfig : IEntityTypeConfiguration<GroupNews>

    {
        public void Configure(EntityTypeBuilder<GroupNews> builder)
        {
           
        }
    }
}
