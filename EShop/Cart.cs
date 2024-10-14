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
        public const string CommandNameAdd = "Add";
        public const string CommandNameShowBalance = "ShowBalance";
        public const string CommandNameCleare = "Clear";

        static internal List<SaleItem> saleItems = new();

        public static void CommandInfo() {
            Console.WriteLine(CommandNameAdd + " Id - добавляет товар или услугу в корзину из последнего " +
                "списка товаров или услуг. Для этого укажите его Id");
            Console.WriteLine(CommandNameShowBalance + " - показать содержание корзины и итоговую сумму");
            Console.WriteLine(CommandNameCleare + " - очистить корзину");
        }

        public static void Add(SaleItem item) {
            saleItems.Add(item);
        }

        public static void Clear()
        {
            saleItems = new();
        }

        public static void ShowBalance()
        {
            var cartSum = 0;
            
            foreach (var item in saleItems)
            {
                Console.WriteLine(item.Info());
                cartSum += item.Price;
            }

            Console.WriteLine("Итоговая сумма корзины: " + cartSum);
        }

    }
}
