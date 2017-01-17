using System;

namespace Greenmist.Console.Commands
{
    public struct ConsoleInfo
    {
        public static ConsoleInfo QUIT = new ConsoleInfo("quit", "Quit this application.", null);
        public static ConsoleInfo CLEAR = new ConsoleInfo("clear", "Clear the console text.", null);

        public string command { get; private set; }
        public string description { get; private set; }
        public string usage { get; private set; }

        public ConsoleInfo(string command, string description, string usage) : this()
        {
            this.command = command;
            this.description = description;
            this.usage = usage;
        }
    }
}