using Core.SaleItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Commands
{
    public class GetProducts
    {
        public const string Name = "GetProducts";

        public static string GetInfo()
        {
            return "вывести список товаров";
        }

        public static Product[] Execute()
        {
            Console.WriteLine("Сколько товаров вам показать?");
            return GetProsucts(Common.GetNumber());
        }

        public static Product[] GetProsucts(int count)
        {

            var prosucts = new Product[count];
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                prosucts[i] = new Product("Товар " + (1 + i), random.Next(100000, 1000000), random.Next(100000, 1000000));
            }

            return prosucts;
        }

    }
}
