using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SaleItems
{
    public class Service : SaleItem
    {
        public Service(string name, int id, int price = 1000)
            : base(name, id, price)
        {
            
        }

        public string Info()
        {
            return $"Товар: {name} ({id}). Цена: {price}";
        }
    }
}
