using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class Common
    {
        public static int GetNumber()
        {
            int result;

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректное целое число.");
                }
            }
        }
    }
}
