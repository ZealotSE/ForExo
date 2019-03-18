using System;

public class ThresholdReachedEventArgs : EventArgs
{
    private string message;

    public ThresholdReachedEventArgs(string i)
    {
        message = i;
    }  

    public override string ToString()
    {
        return message;
    }
}