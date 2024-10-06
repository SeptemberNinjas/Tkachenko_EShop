namespace EShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayWalcome();

            while (true)
            {
                Console.Write("Введите команду:");
                var command = GetCommand();
                DysplayCommandCommander.Execute(command);
            }
        }

        private static void SayWalcome()
        {
            Console.WriteLine("Добро пожаловать");
        }

        private static string GetCommand()
        {
            var command = Console.ReadLine();

            while (command == null)
            {
                Console.WriteLine("Некорректный ввод команды. Для отображения всех комманд используйте " + DysplayCommandCommander.GetInfo());
                command = Console.ReadLine();
            }

            return command;
        }
    }
}
