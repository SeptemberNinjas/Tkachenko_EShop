using Core.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EShop
{

    public class DysplayCommandCommander
    {
        public static string GetInfo() {
            return CommandsCommander.Name;
        }
        
        public static void Execute(string command)
        {
            var commands = new List<string>();

            switch (command)
            {
                case CommandsCommander.Name:
                    commands = CommandsCommander.Execute();

                    foreach (var commandInfo in commands)
                        Console.WriteLine(commandInfo);

                    break;
                case ExitCommand.Name:
                    ExitCommand.Execute();
                    break;
                case GetProducts.Name:
                    var products = GetProducts.Execute();

                    foreach (var product in products)
                        Console.WriteLine(product.Info());

                    break;
                default:
                    Console.WriteLine("Ошибка: неизвестная команда");
                    Console.WriteLine("Доступные команда");

                    commands = CommandsCommander.Execute();

                    foreach (var commandInfo in commands)
                        Console.WriteLine(commandInfo);

                    break;
            }
        }
    }
}
