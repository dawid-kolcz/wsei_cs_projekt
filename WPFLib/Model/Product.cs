using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLib.Model
{
    /// <summary>
    /// Klasa ktora przechowuje produkty z ktorych sklada sie przepis.
    /// </summary>
    public class Product
    {
        public Product()
        {
            Dish = new HashSet<Dish>();
        }
        public int ID { get; set; }
        public string Name { get; set; }

        [Required]
        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<Dish> Dish { get; set; }

        public override string ToString()
        {
            return $"{Name} - {ProductType.Type}";
        }
    }
}
