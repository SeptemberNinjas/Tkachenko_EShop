using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SaleItems
{
    public class SaleItem
    {
        internal string Name { get; }
        public int Id { get; }
        public int Price { get; set; }

        public SaleItem(string name, int id, int price)
        {
            this.Name = name;
            this.Id = id;
            this.Price = price;
        }

        public string Info()
        {
            return $"Товар: {Name} ({Id}). Цена: {Price}";
        }
    }
}
