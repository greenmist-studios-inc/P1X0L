using System;
using UniRx;

namespace Greenmist.Console.Commands
{
    public abstract class ConsoleCommand
    {
        public String command { get; private set; }
        public String description { get; private set; }
        public String usage { get; private set; }

        protected ConsoleCommand(ConsoleInfo consoleInfo)
        {
            command = consoleInfo.command;
            description = consoleInfo.description;
            usage = consoleInfo.usage;
        }

        public ConsoleCommand(String command, string description, string usage)
        {
            this.command = command;
            this.description = String.IsNullOrEmpty(description.Trim()) ? "No description provided" : description;
            this.usage = String.IsNullOrEmpty(usage.Trim()) ? "No usage information provided" : usage;
        }

        public abstract IObservable<String> Execute(String[] args);
    }
}