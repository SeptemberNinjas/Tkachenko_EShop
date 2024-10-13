using Core.SaleItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Cart
    {
        internal List<SaleItem> saleItems = new List<SaleItem>();

        public void Add(SaleItem item) {
            saleItems.Add(item);
        }

        public List<string> ShowBalance()
        {
            var cartSum = 0;
            var data = new List<string>();

            foreach (var item in saleItems)
            {
                data.Add(item.Info());
                cartSum += item.price;
            }

            data.Add("Итоговая сумма корзины: " + cartSum));

            return data;
        }

    }
}
