using System;

namespace Greenmist.Console.Model {

	public enum LogLevel {
		Verbose = 5,
		Debug = 5,
		Info = 3,
		Warn = 2,
		Error = 1
	}

	public static class LogLevelExtentions {
		public static String ConsoleLogLevelString(this LogLevel logLevel) {
			return logLevel.ToString ().Substring (0, 1) + ": ";
		}
	}
}