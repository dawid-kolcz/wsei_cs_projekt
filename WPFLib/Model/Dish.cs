using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WPFLib.Model
{
    public class Dish
    {
        public Dish()
        {
            Products = new HashSet<Product>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        [Required]
        public virtual ICollection<Product> Products { get; set; }
        [Required]
        public virtual DishType DishType { get; set; }

        public override string ToString()
        {
            return $"{Name} - {DishType.Type}";
        }
    }
}
