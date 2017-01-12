using System;
using System.Diagnostics;

namespace Greenmist.Console.Model
{
	public class Entry
	{
	    public string EntryMessage { get; private set; }
	    public LogLevel LogLevel { get; private set; }
	    public StackTrace StackTrace { get; private set; }
	    public DateTime TimeStamp { get; private set; }

	    public Entry (LogLevel logLevel, String entryMessage)
		{
			EntryMessage = entryMessage;
			LogLevel = logLevel;
		    StackTrace = new StackTrace();
		    TimeStamp = new DateTime();
		}

	    public override String ToString() {
			return "EntryMessage=" + EntryMessage +
				", LogLevel=" + LogLevel +
				", StackTrace=" + StackTrace +
	            ", DateTime=" + TimeStamp;
	    }
	}
}

