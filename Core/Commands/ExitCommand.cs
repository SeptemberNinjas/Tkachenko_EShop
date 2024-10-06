using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Commands
{
    public class ExitCommand
    {
        public const string Name = "Exit";

        public static string GetInfo()
        {
            return "Выйти из программы";
        }

        public static void Execute()
        {
            Environment.Exit(0);
        }
    }
}
