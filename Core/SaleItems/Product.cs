using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SaleItems
{
    public class Product : SaleItem
    {
        int balanse { get; set; }

        public Product (string name, int id, int price = 1000)
            : base (name, id, price)
        {
            
            balanse = 10;
        }

        public string Info() {
            return $"Товар: {Name} ({Id}), доступен в количестве: {balanse}. Цена: {Price}";
        }

    }
}
