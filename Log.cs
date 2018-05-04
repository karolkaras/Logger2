using System;
using System.Diagnostics;
using System.Diagnostics.Eventing;
using System.IO;

public class Log
{
    public String logSource;
    public String logMessage;
    public int eventID;
    public EventLog eLog;
    public StreamWriter writetext;
    public Log(String source, String Message, int id )
	{
        this.logMessage = source;
        this.logSource = Message;
        this.eventID = id;
    }
    
    public void EventLogWritter()
    {
        eLog = new EventLog();
        eLog.Source = logSource;

        
        
            eLog.WriteEntry(logMessage,
                            System.Diagnostics.EventLogEntryType.Error,
                            eventID);


            eLog.Close();
        }
   
    public void TxtLog()
    {
        StreamWriter writetext = new StreamWriter("write.txt");
        writetext.WriteLine("writing in text file");
    }   
           
        }
        





