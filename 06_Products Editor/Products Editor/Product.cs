using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Editor
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Country { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }

        public override string ToString()
        {
            return $" {Name} - {Price}grn";
        }

    }
}
