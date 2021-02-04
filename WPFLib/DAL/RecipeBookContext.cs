using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WPFLib.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WPFLib.DAL
{
    public class RecipeBookContext : DbContext
    {
        public RecipeBookContext() : base("RecipeBookContext")
        {
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishType> DishTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
