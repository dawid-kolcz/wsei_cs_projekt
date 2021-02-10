using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLib.Model
{
    public class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }
        public int ID { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
