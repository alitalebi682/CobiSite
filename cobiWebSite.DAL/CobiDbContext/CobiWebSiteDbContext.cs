using CobiWebSite.Model.News.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobiWebSite.DAL.CobiDbContext
{
    public class CobiWebSiteDbContext : DbContext
    {

        public DbSet<NewsBase> NewsBases { get; set; }
        public DbSet<GroupNews> GroupNews { get; set; }
        public DbSet<TypeNewsBase> TypeNewsBases { get; set; }
        public DbSet<NewseRelated> NewsRelateds { get; set; }
        public DbSet<SingleUploadFile> SingleUploadFiles { get; set; }





        public CobiWebSiteDbContext(DbContextOptions<CobiWebSiteDbContext> options) : base(options)
        {



        }
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

    //        modelBuilder.Entity<Student>()
    //.HasOne<StudentAddress>(s => s.Address)
    //.WithOne(ad => ad.Student)
    //.HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);


    //        modelBuilder.Entity<NewsBase>().HasOne<GroupNews>(s =>s.N).WithOne(Na =>Na.

            foreach ( var item in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(item.ClrType).Property<string>("CreatingBy").HasMaxLength(50);
                modelBuilder.Entity(item.ClrType).Property<string>("UpdateBy").HasMaxLength(50);
                modelBuilder.Entity(item.ClrType).Property<DateTime>("CreatingDate").HasMaxLength(50);
                modelBuilder.Entity(item.ClrType).Property<DateTime>("UpdateDate").HasMaxLength(50);

                modelBuilder.Entity(item.ClrType).Property<Boolean>("IsActive");

            }

        }
    }
    
}

