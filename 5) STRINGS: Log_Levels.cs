/*
In this exercise you'll be processing log-lines.

Each log line is a string formatted as follows: "[<LEVEL>]: <MESSAGE>".

There are three different log levels:

INFO
WARNING
ERROR
You have three tasks, each of which will take a log line and ask you to do something with it.

1. Get message from a log line
Implement the (static) LogLine.Message() method to return a log line's message:

LogLine.Message("[ERROR]: Invalid operation")
// => "Invalid operation"
Any leading or trailing white space should be removed:

LogLine.Message("[WARNING]:  Disk almost full\r\n")
// => "Disk almost full"
2. Get log level from a log line
Implement the (static) LogLine.LogLevel() method to return a log line's log level, which should be returned in lowercase:

LogLine.LogLevel("[ERROR]: Invalid operation")
// => "error"
3. Reformat a log line
Implement the (static) LogLine.Reformat() method that reformats the log line, putting the message first and the log level after it in parentheses:

LogLine.Reformat("[INFO]: Operation completed")
// => "Operation completed (info)"
*/

using System;

static class LogLine
{
    public static string Message(string logLine)
    {
         return logLine.Substring(logLine.IndexOf(":") + 1).Trim();
        
        //Using substring we acess the log header message : how do we do that..? 
        //log header looks like this [ERROR]: so the message will be starting after this symobol ":"
        //Trim is an inbuilt function to remove both staring and ending spaces.
        //we can use Trim.Start() and Trim.End() to remove starting or ending spaces respectivly.
         
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
         return logLine.Substring(1, logLine.IndexOf("]") -1).ToLower();
        //here using substring we traverse the log index how do we do that..?
        //there are two ways : 1) where we start from "[" till the next few words which we do not know how much words more in log header.
        //or we can traverse back that is from "]" till the first position , because in 0th pos you will have "[" this symbol. 
        // so we start from Substring(1, logLine.IndexOf("]") -1) and then we convert this header content into lower case using : ToLower();
        
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}





