using System;
using UnityEngine;
using UniRx;
using UniRx.Diagnostics;
using Greenmist.Console.Model;

namespace Greenmist.Console {

	public class Console : MonoBehaviour {

		[SerializeField]
		protected int fps = 30;
		private Subject<Entry> consoleOutputSubject = new Subject<Entry>();

		// Use this for initialization
		void Start ()
		{

		}

		// Update is called once per frame
		void Update () {
			
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

		private void Log(LogLevel logLevel, String message) {
		    UnityEngine.Debug.Log (logLevel.ConsoleLogLevelString() + message);
			Entry entry = new Entry (logLevel, message);
			consoleOutputSubject.OnNext (entry);
		}

		public void Subscribe(IObserver<Entry> observer) {
			consoleOutputSubject.Debug("Console").Subscribe (observer);
		}
	}
}