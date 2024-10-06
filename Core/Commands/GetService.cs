using Core.SaleItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Commands
{
    public class GetService
    {
        public const string Name = "GetService";

        public static string GetInfo()
        {
            return "вывести список услуг";
        }

        public static Service[] Execute()
        {
            Console.WriteLine("Сколько услуг вам показать?");
            return GetServices(Common.GetNumber());
        }

        public static Service[] GetServices(int count)
        {

            var services = new Service[count];
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                services[i] = new Service("Услуга " + (1 + i), random.Next(100000, 1000000), random.Next(100000, 1000000));
            }

            return services;
        }

    }
}
