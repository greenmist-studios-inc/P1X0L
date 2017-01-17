using System;
using UnityEngine;
using UniRx;
using UniRx.Diagnostics;
using Greenmist.Console.Model;
using UnityEngine.UI;

namespace Greenmist.Console {

	public class Console : MonoBehaviour
	{
	    [SerializeField]
	    private Text text;
	    [SerializeField]
	    private ScrollRect scrollRect;
	    [SerializeField]
	    public bool logOutput;

	    private Subject<Entry> consoleOutputSubject = new Subject<Entry>();

		// Use this for initialization
		void Start ()
		{

		}

		// Update is called once per frame
		void Update ()
		{
			//D("test");
		}

		public void V(String message) {
			Log (LogLevel.Verbose, message);
		}

		public void D(String message) {
			Log (LogLevel.Debug, message);
		}

		public void I(String message) {
			Log (LogLevel.Info, message);
		}

		public void W(String message) {
			Log (LogLevel.Warn, message);
		}

		public void E(String message) {
			Log (LogLevel.Error, message);
		}

		private void Log(LogLevel logLevel, String message)
		{
		    if (logOutput)
		        Debug.Log(logLevel.ConsoleLogLevelString() + message);

		    Entry entry = new Entry (logLevel, message);
			consoleOutputSubject.OnNext (entry);
		    text.text += message + "\n";
		}

	    public void Clear()
	    {
	        text.text = "";
	    }

		public void Subscribe(IObserver<Entry> observer) {
			consoleOutputSubject.Debug("Console").Subscribe (observer);
		}
	}
}