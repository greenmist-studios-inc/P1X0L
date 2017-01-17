using UniRx;

namespace Greenmist.Console.Commands
{
    public class ClearCommand : ConsoleCommand
    {
        private Console console;

        public ClearCommand(Console console) : base(ConsoleInfo.CLEAR)
        {
            this.console = console;
        }

        public override IObservable<string> Execute(string[] args)
        {
            return Observable.Create<string>(o =>
            {
                CompositeDisposable compositeDisposable = new CompositeDisposable();

                console.Clear();
                o.OnCompleted();

                return compositeDisposable;
            });
        }
    }
}