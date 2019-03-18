using System;

public class EventArgs : System.EventArgs
{
    public string command;

    public EventArgs(string command)
    {
        this.command = command;
    }  

    public override string ToString()
    {
        return command;
    }
}