using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore实现值对象
{
    internal class MyDbcontext:DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Order> Orders { get; set; }    
        public DbSet<Goods> Goods { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=DotnetCore2022;Trusted_Connection=true;MultipleActiveResultSets=true;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //从当前程序集中加载所有的IEntityTypeConfiguration
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
