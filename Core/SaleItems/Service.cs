using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SaleItems
{
    public class Service
    {
        string Name { get; set; }
        int Id { get; set; }
        int Price { get; set; }

        public Service(string name, int id, int price = 1000)
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
