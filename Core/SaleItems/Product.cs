using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SaleItems
{
    public class Product
    {
        string Name { get; set; }
        int Id { get; set; }
        int Price { get; set; }
        int Balanse { get; set; }

        public Product(string name, int id, int price = 1000)
        {
            this.Name = name;
            this.Id = id;
            this.Price = price;
            this.Balanse = 10;
        }

        public string Info() {
            return $"Товар: {Name} ({Id}), доступен в количестве: {Balanse}. Цена: {Price}";
        }

    }
}
