using System;
using UniRx;

namespace Greenmist.Console.Commands
{
    public class QuitCommand : ConsoleCommand
    {
        public QuitCommand() : base(ConsoleInfo.QUIT)
        {
        }

        public override IObservable<string> Execute(String[] args)
        {
            return Observable.Create<String>(o =>
            {
                CompositeDisposable compositeDisposable = new CompositeDisposable();

                o.OnNext("Quitting Application...");

                if (!compositeDisposable.IsDisposed)
                {
                    UnityEngine.Application.Quit();
#if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
#endif
                }

                o.OnCompleted();

                return compositeDisposable;
            });
        }
    }
}