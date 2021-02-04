using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLib.Model
{
    public class Dish
    {
        public int ID { get; set; }
        public int DishTypeID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual DishType DishType { get; set; }
    }
}
