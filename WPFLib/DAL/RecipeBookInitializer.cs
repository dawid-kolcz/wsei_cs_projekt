using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WPFLib.Model;

namespace WPFLib.DAL
{
    public class RecipeBookInitializer : CreateDatabaseIfNotExists<RecipeBookContext>
    {
        protected override void Seed(RecipeBookContext context)
        {          
            var productTypes = new List<ProductType>
            {
                new ProductType {Type = "Owoc"},
                new ProductType {Type = "Warzywo"},
                new ProductType {Type = "Mięso"},
                new ProductType {Type = "Ryba"},
                new ProductType {Type = "Przyprawa"},
                new ProductType {Type = "Nabiał"},
                new ProductType {Type = "Produkt suchy"},
                new ProductType {Type = "Wędlina"},
                new ProductType {Type = "Olej"}
            };
            productTypes.ForEach(pt => context.ProductTypes.Add(pt));
            context.SaveChanges();

            var dishTypes = new List<DishType>
            {
                new DishType {Type = "Wegetariańskie"},
                new DishType {Type = "Wegańskie"},
                new DishType {Type = "Bez glutenowe"},
                new DishType {Type = "Pikantne"}
            };
            dishTypes.ForEach(dt => context.DishTypes.Add(dt));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{Name = "Jajka",           ProductType = productTypes[5]},
                new Product{Name = "Mąka",            ProductType = productTypes[6]},
                new Product{Name = "Masło",           ProductType = productTypes[5]},
                new Product{Name = "Kiełbasa",        ProductType = productTypes[7]},
                new Product{Name = "Boczek",          ProductType = productTypes[2]},
                new Product{Name = "Sól",             ProductType = productTypes[4]},
                new Product{Name = "Pieprz",          ProductType = productTypes[4]},
                new Product{Name = "Makaron Fusilli", ProductType = productTypes[6]},
                new Product{Name = "Pomidor",         ProductType = productTypes[1]},
                new Product{Name = "Jabłko",          ProductType = productTypes[0]},
                new Product{Name = "Pieprz Cayenne",  ProductType = productTypes[4]},
                new Product{Name = "Oliwa",           ProductType = productTypes[8]},
                new Product{Name = "Parmezan",        ProductType = productTypes[5]},
                new Product{Name = "Czosnek",         ProductType = productTypes[1]}
            };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();

            var dish = new List<Dish>
            {
                new Dish{Name = "Jajecznica", Description = "Smażony mix jajek na maśle z solą i pieprzem.", 
                    DishType = dishTypes[0],
                    Products = {products[0], products[2], products[5], products[6] } },
                new Dish{Name = "Fusilli aglio e olio", Description = "Makaron typu fusilli z oliwa i czosnkiem. Po wyłożeniu należy posypać tartym parmezanem.",
                    DishType = dishTypes[1],
                    Products = {products[5], products[6], products[7], products[11], products[12], products[13] } }
            };
            dish.ForEach(d => context.Dishes.Add(d));
        }
    }
}
