using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLib.Model
{
    public class ProductType
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public virtual Product Product { get; set; }
    }
}
