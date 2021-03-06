﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLib.Model
{
    /// <summary>
    /// Klasa przechowujaca typ potrawy.
    /// </summary>
    public class DishType
    {
        public DishType()
        {
            Dish = new HashSet<Dish>();
        }
        public int ID { get; set; }
        public int DishID { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Dish> Dish { get; set; }

        public override string ToString()
        {
            return Type;
        }
    }
}
