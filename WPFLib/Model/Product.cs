using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLib.Model
{
    public class Product
    {
        public int ID { get; set; }
        public int ProductTypeID { get; set; }
        public int DishID { get; set; }
        public string Name { get; set; }
        [Required]
        public virtual ProductType ProductType { get; set; }
        public virtual Dish Dish { get; set; }
}
}
