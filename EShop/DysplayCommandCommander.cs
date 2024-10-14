using Core;
using Core.Commands;
using Core.SaleItems;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EShop
{

    public class DysplayCommandCommander
    {
        static Dictionary<int, SaleItem> saleItems = new();

        public static string GetInfo()
        {
            return CommandsCommander.Name;
        }

        public static void Execute(string command)
        {
            var commands = new List<string>();
            var commandParametrs = new List<string>();

            PrepareCommandName(out command, out commandParametrs, command); // TODO: тут можно как-то обойтись 2 параметрами?

            switch (command)
            {
                case CommandsCommander.Name:
                    commands = CommandsCommander.Execute();

                    foreach (var commandInfo in commands)
                        Console.WriteLine(commandInfo);

                    Cart.CommandInfo();

                    break;
                case ExitCommand.Name:
                    ExitCommand.Execute();
                    break;
                case GetProducts.Name:
                    var products = GetProducts.Execute();
                    saleItems = new();

                    foreach (var product in products)
                    {
                        Console.WriteLine(product.Info());
                        saleItems.Add(product.Id, product);
                    }

                    break;
                case GetService.Name:
                    var services = GetService.Execute();
                    saleItems = new();

                    foreach (var service in services)
                    {
                        Console.WriteLine(service.Info());
                        saleItems.Add(service.Id, service);
                    }

                    break;
                case Cart.CommandNameAdd:
                    if (commandParametrs.Count() == 0)
                    {
                        Console.WriteLine("Id не введен. Пожалуйста, введите корректно команду");
                        break;
                    }


                    var id = 0;

                    if (int.TryParse(commandParametrs[0], out id))
                    {
                        if (saleItems.TryGetValue(id, out var item))
                            Cart.Add(item);
                        else
                            Console.WriteLine("Такой Id не найден в списке. Пожалуйста, введите корректно команду.");
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод Id. Пожалуйста, введите корректно команду.");
                    }

                    break;
                case Cart.CommandNameShowBalance:
                    Cart.ShowBalance();

                    break;
                case Cart.CommandNameCleare:
                    Cart.Clear();

                    break;
                default:
                    Console.WriteLine("Ошибка: неизвестная команда");
                    Console.WriteLine("Доступные команда");

                    commands = CommandsCommander.Execute();

                    foreach (var commandInfo in commands)
                        Console.WriteLine(commandInfo);

                    Cart.CommandInfo();

                    break;
            }
        }

        private static void PrepareCommandName(out string command, out List<string> commandParametrs, string commandBase)
        {

            string[] parts = commandBase.Split(" ");

            command = parts[0];
            commandParametrs = new List<string>(); //тут же и так уже чистый список. Можно ли как-то избежать дополнительного присваивания?

            // Если есть параметры, добавляем их в список
            for (int i = 1; i < parts.Length; i++)
            {
                commandParametrs.Add(parts[i]);
            }

        }
    }
}
