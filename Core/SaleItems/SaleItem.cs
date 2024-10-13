using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SaleItems
{
    public class SaleItem
    {
        internal string name { get; }
        internal int id { get; }
        internal int price { get; set; }

        public SaleItem(string name, int id, int price)
        {
            this.name = name;
            this.id = id;
            this.price = price;
        }

        public string Info()
        {
            return $"Товар: {name} ({id}). Цена: {price}";
        }
    }
}
