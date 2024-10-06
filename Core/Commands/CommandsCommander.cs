namespace Core.Commands
{
    public static class CommandsCommander
    {
        public const string Name = "DisplayCommands";

        public static string GetInfo()
        {
            return "Ввести список команды";
        }

        public static List<string> Execute()
        {
            var commands = new List<string>();

            commands.Add($"{Name} - {GetInfo()}");
            commands.Add($"{ExitCommand.Name} - {ExitCommand.GetInfo()}");

            return commands;
        }
    }
}
