using CobiWebSite.Model.News.Entities;
using CobiWebSite.Model.News.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobiWebSite.DAL.NewsConfig
{
    public static class NewsQueryExtensions
    {

        public static IQueryable<NewsBase> WhereOver(this IQueryable<NewsBase> NewsBases, string Type)
        {
            if (!string.IsNullOrEmpty(Type))

                NewsBases = NewsBases.Where(t => t.Type.Contains(Type));
            return NewsBases;

        }
        public static List<NewsBaseQr> ToNewsBaseQrs(this IQueryable<NewsBase> NewsBases)
        {
            return NewsBases.Select(c => new NewsBaseQr

            {
                Id = c.Id,
                Type = c.Type
            }).ToList();

        }

        public static async Task<List<NewsBaseQr>> ToNewsBaseQrsAsync(this IQueryable<NewsBase> NewsBases)
        {
            return await NewsBases.Select(c => new NewsBaseQr

            {
                Id = c.Id,
                Type = c.Type
            }).ToListAsync();

        }
    }
}
