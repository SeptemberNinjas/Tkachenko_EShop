using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SaleItems
{
    public class SaleItem
    {
        string name { get; set; }
        int id { get; set; }
        int price { get; set; }

        public SaleItem(string name, int id, int price = 1000)
        {
            this.name = name;
            this.id = id;
            this.price = price;
        }
    }
}
