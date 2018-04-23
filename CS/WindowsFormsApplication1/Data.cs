using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Data
    {
        public Data()
        {
            Name = string.Empty;
            Category = string.Empty;
            Price = 0;
        }

        public Data(String name, String category, Double price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public String Name { get; set; }
        public String Category { get; set; }
        public Double Price { get; set; }
    }
}
